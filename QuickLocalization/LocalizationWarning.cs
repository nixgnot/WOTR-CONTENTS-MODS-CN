namespace QuickLocalization;

public class LocalizationWarning
{
    public LocalizationWarning(string fileName, string warning)
    {
        FileName = fileName;
        Warning = warning;
    }

    public string FileName { get; set; }
    public string Warning { get; set; }
}