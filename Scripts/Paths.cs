using System;
using System.IO;
using System.Windows.Forms;

public static class Paths
{
    public static string Base =>
        Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "Logbook");

    public static string Logs => Path.Combine(Base, "Logs");

    public static string Accounts => Path.Combine(Base, "Accounts");
    public static string Media => Path.Combine(Base, "Media");
    public static string Images => Path.Combine(Media, "Images");
    public static string Audio => Path.Combine(Media, "Audio");

    public static void EnsureCreated()
    {
        Directory.CreateDirectory(Base);
        Directory.CreateDirectory(Logs);
        Directory.CreateDirectory(Accounts);
        Directory.CreateDirectory(Images);
        Directory.CreateDirectory(Audio);
    }
}
