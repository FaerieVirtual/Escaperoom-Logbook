using Logbook.Properties;
using NAudio.Wave;
using System;
using System.Windows.Forms;

public class Recording
{
    public string name;
    public string path;

    public int volume;
    public double durationTime;

    public WaveOutEvent output;
    public AudioFileReader audioFile;

    public void PlayPause(Button button)
    {
        if (output == null || audioFile == null)
            InitPlayer();

        if (output.PlaybackState == PlaybackState.Playing)
        {
            output.Pause();
            button.BackgroundImage = Resources.play;
        }
        else
        {
            output.Play();
            button.BackgroundImage = Resources.pause;
        }
    }

    private void InitPlayer()
    {
        DisposePlayer();

        audioFile = new AudioFileReader(path);
        output = new WaveOutEvent();
        output.Init(audioFile);
    }

    public void StopTrack(Button button, ProgressBar bar)
    {
        if (output == null || audioFile == null)
            return;

        output.Stop();
        audioFile.Position = 0; // Návrat na začátek

        bar.Value = 0;
        button.BackgroundImage = Resources.play;
    }

    public void AdjustVolume(double value)
    {
        if (output != null)
            output.Volume = (float)value;  // 0–1
    }

    public void AdjustTrack(int ms)
    {
        if (audioFile == null)
            return;

        long bytesPerMs = audioFile.WaveFormat.AverageBytesPerSecond / 1000;
        long newPos = audioFile.Position + bytesPerMs * ms;

        newPos = Math.Clamp(newPos, 0, audioFile.Length);
        audioFile.Position = newPos;
    }

    private void DisposePlayer()
    {
        output?.Stop();
        output?.Dispose();
        audioFile?.Dispose();

        output = null;
        audioFile = null;
    }
}
