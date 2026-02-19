using System;
using System.IO;

public static class Paths
{
    public static string Base =>
        Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "Logbook");

    public static string Logs => Path.Combine(Base, "Logs");

    public static string Accounts => Path.Combine(Base, "Accounts");
}
