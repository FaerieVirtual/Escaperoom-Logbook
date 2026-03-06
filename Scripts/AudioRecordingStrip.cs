using Logbook.Properties;
using NAudio.Wave;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

public class AudioRecordingStrip : UserControl
{
    public string path;

    public int volume = 1;

    public WaveOutEvent output;
    public AudioFileReader audioFile;

    private TableLayoutPanel MainPanel;
    private TableLayoutPanel RightPanel;
    private TrackBar VolumeSlider;
    public Label NameLabel;
    private TableLayoutPanel ButtonPanel;
    private Button AdvanceButton;
    private Button RewindButton;
    private Button StopButton;
    private ProgressBar ProgressBar;
    private Button PlayButton;
    private Timer RefreshTimer;
    private System.ComponentModel.IContainer components;

    public AudioRecordingStrip(string fileName)
    {
        path = Path.Combine(Paths.Audio, fileName);

        MinimumSize = new Size(616, 124);

        InitializeComponent();
        InitPlayer();
    }

    public void PlayPause()
    {
        if (output == null || audioFile == null)
            InitPlayer();
        RefreshTimer.Start();
        if (output.PlaybackState == PlaybackState.Playing)
        {
            output.Pause();
            PlayButton.BackgroundImage = Resources.play;
        }
        else
        {
            output.Play();
            PlayButton.BackgroundImage = Resources.pause;
        }
    }

    private void InitPlayer()
    {
        DisposePlayer();

        audioFile = new AudioFileReader(path);
        output = new WaveOutEvent();
        output.Init(audioFile);

        ProgressBar.Maximum = (int)(audioFile.Length / 1000);
        NameLabel.Text = Path.GetFileName(audioFile.FileName);
    }

    public void StopTrack(ProgressBar bar)
    {
        if (output == null || audioFile == null)
            return;

        RefreshTimer.Stop();
        output.Stop();
        audioFile.Position = 0;

        bar.Value = 0;
        PlayButton.BackgroundImage = Resources.play;
    }

    public void AdjustVolume(double value)
    {
        if (output != null)
            output.Volume = (float)value / 100;
    }

    public void AdjustTrack(int ms)
    {
        if (audioFile == null) return;

        long bytesPerMs = audioFile.WaveFormat.AverageBytesPerSecond / 1000;
        long newPos = audioFile.Position + bytesPerMs * ms;

        newPos = Math.Clamp(newPos, 0, audioFile.Length);
        audioFile.Position = newPos;
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        MainPanel = new TableLayoutPanel();
        RightPanel = new TableLayoutPanel();
        VolumeSlider = new TrackBar();
        NameLabel = new Label();
        ButtonPanel = new TableLayoutPanel();
        AdvanceButton = new Button();
        RewindButton = new Button();
        StopButton = new Button();
        ProgressBar = new ProgressBar();
        PlayButton = new Button();
        RefreshTimer = new Timer(components);
        MainPanel.SuspendLayout();
        RightPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)VolumeSlider).BeginInit();
        ButtonPanel.SuspendLayout();
        SuspendLayout();
        // 
        // MainPanel
        // 
        MainPanel.AutoSize = true;
        MainPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
        MainPanel.ColumnCount = 2;
        MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21F));
        MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79F));
        MainPanel.Controls.Add(RightPanel, 1, 0);
        MainPanel.Controls.Add(PlayButton, 0, 0);
        MainPanel.Location = new Point(0, 0);
        MainPanel.Name = "MainPanel";
        MainPanel.RowCount = 1;
        MainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        MainPanel.Size = new Size(616, 124);
        MainPanel.TabIndex = 14;
        // 
        // RightPanel
        // 
        RightPanel.ColumnCount = 1;
        RightPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        RightPanel.Controls.Add(VolumeSlider, 0, 2);
        RightPanel.Controls.Add(NameLabel, 0, 0);
        RightPanel.Controls.Add(ButtonPanel, 0, 1);
        RightPanel.Dock = DockStyle.Fill;
        RightPanel.Location = new Point(135, 5);
        RightPanel.Name = "RightPanel";
        RightPanel.RowCount = 3;
        RightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
        RightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
        RightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
        RightPanel.Size = new Size(476, 114);
        RightPanel.TabIndex = 0;
        // 
        // VolumeSlider
        // 
        VolumeSlider.Dock = DockStyle.Fill;
        VolumeSlider.Location = new Point(3, 82);
        VolumeSlider.Maximum = 100;
        VolumeSlider.Minimum = 1;
        VolumeSlider.Name = "VolumeSlider";
        VolumeSlider.Size = new Size(470, 29);
        VolumeSlider.TabIndex = 15;
        VolumeSlider.Value = 100;
        VolumeSlider.Scroll += VolumeSlider_Scroll;
        // 
        // NameLabel
        // 
        NameLabel.AutoSize = true;
        NameLabel.Dock = DockStyle.Fill;
        NameLabel.Location = new Point(3, 0);
        NameLabel.Name = "NameLabel";
        NameLabel.Size = new Size(470, 34);
        NameLabel.TabIndex = 16;
        NameLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // ButtonPanel
        // 
        ButtonPanel.ColumnCount = 4;
        ButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 42F));
        ButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 42F));
        ButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 42F));
        ButtonPanel.ColumnStyles.Add(new ColumnStyle());
        ButtonPanel.Controls.Add(AdvanceButton, 2, 0);
        ButtonPanel.Controls.Add(RewindButton, 1, 0);
        ButtonPanel.Controls.Add(StopButton, 0, 0);
        ButtonPanel.Controls.Add(ProgressBar, 3, 0);
        ButtonPanel.Dock = DockStyle.Fill;
        ButtonPanel.Location = new Point(3, 37);
        ButtonPanel.Name = "ButtonPanel";
        ButtonPanel.RowCount = 1;
        ButtonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        ButtonPanel.Size = new Size(470, 39);
        ButtonPanel.TabIndex = 17;
        // 
        // AdvanceButton
        // 
        AdvanceButton.BackgroundImage = Resources.forward;
        AdvanceButton.BackgroundImageLayout = ImageLayout.Zoom;
        AdvanceButton.Dock = DockStyle.Fill;
        AdvanceButton.Location = new Point(87, 3);
        AdvanceButton.Name = "AdvanceButton";
        AdvanceButton.Size = new Size(36, 33);
        AdvanceButton.TabIndex = 4;
        AdvanceButton.UseVisualStyleBackColor = true;
        AdvanceButton.Click += AdvanceButton_Click;
        // 
        // RewindButton
        // 
        RewindButton.BackgroundImage = Resources.backward;
        RewindButton.BackgroundImageLayout = ImageLayout.Zoom;
        RewindButton.Dock = DockStyle.Fill;
        RewindButton.Location = new Point(45, 3);
        RewindButton.Name = "RewindButton";
        RewindButton.Size = new Size(36, 33);
        RewindButton.TabIndex = 3;
        RewindButton.UseVisualStyleBackColor = true;
        RewindButton.Click += RewindButton_Click;
        // 
        // StopButton
        // 
        StopButton.BackgroundImage = Resources.stop;
        StopButton.BackgroundImageLayout = ImageLayout.Zoom;
        StopButton.Dock = DockStyle.Fill;
        StopButton.Location = new Point(3, 3);
        StopButton.Name = "StopButton";
        StopButton.Size = new Size(36, 33);
        StopButton.TabIndex = 2;
        StopButton.UseVisualStyleBackColor = true;
        StopButton.Click += StopButton_Click;
        // 
        // ProgressBar
        // 
        ProgressBar.Dock = DockStyle.Fill;
        ProgressBar.Location = new Point(129, 3);
        ProgressBar.Name = "ProgressBar";
        ProgressBar.Size = new Size(338, 33);
        ProgressBar.TabIndex = 5;
        // 
        // PlayButton
        // 
        PlayButton.BackgroundImage = Resources.play;
        PlayButton.BackgroundImageLayout = ImageLayout.Zoom;
        PlayButton.Dock = DockStyle.Fill;
        PlayButton.Location = new Point(5, 5);
        PlayButton.Name = "PlayButton";
        PlayButton.Size = new Size(122, 114);
        PlayButton.TabIndex = 1;
        PlayButton.UseVisualStyleBackColor = true;
        PlayButton.Click += PlayButton_Click;
        // 
        // RefreshTimer
        // 
        RefreshTimer.Interval = 200;
        RefreshTimer.Tick += RefreshTimer_Tick;
        // 
        // AudioRecordingStrip
        // 
        Controls.Add(MainPanel);
        Name = "AudioRecordingStrip";
        Size = new Size(616, 124);
        MainPanel.ResumeLayout(false);
        RightPanel.ResumeLayout(false);
        RightPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)VolumeSlider).EndInit();
        ButtonPanel.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();

    }

    private void DisposePlayer()
    {
        output?.Stop();
        output?.Dispose();
        audioFile?.Dispose();

        output = null;
        audioFile = null;
    }

    private void PlayButton_Click(object sender, EventArgs e)
    {
        PlayPause();
    }

    private void StopButton_Click(object sender, EventArgs e)
    {
        StopTrack(ProgressBar);
    }

    private void RewindButton_Click(object sender, EventArgs e)
    {
        AdjustTrack(-5000);
    }

    private void AdvanceButton_Click(object sender, EventArgs e)
    {
        AdjustTrack(5000);
    }

    private void VolumeSlider_Scroll(object sender, EventArgs e)
    {
        AdjustVolume(VolumeSlider.Value);
    }

    private void RefreshTimer_Tick(object sender, EventArgs e)
    {
        ProgressBar.Value = (int)(audioFile.Position / 1000);
    }
}

