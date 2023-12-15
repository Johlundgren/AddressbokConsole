using AddressbokConsole.Interfaces;
using System.Diagnostics;

namespace AddressbokConsole.Services;

internal class FileService : IFileService
{
    public string GetContentFromFile(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath);
            }
        }
        catch (Exception ex){ Debug.WriteLine("FileService - ReadContentFromFile:: " + ex.Message); }
        return null!;

    }

    public bool SaveContentToFile(string filePath, string content)
    {
        try
        {
            using var sw = new StreamWriter(filePath);
            sw.WriteLine(content);
            return true;
        }
        catch (Exception ex) { Debug.WriteLine("FileService - SaveContentToFile:: " + ex.Message); }
        return false!;
    }
}
