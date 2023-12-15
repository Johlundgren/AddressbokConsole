namespace AddressbokConsole.Interfaces;

internal interface IFileService
{
    /// <summary>
    /// Save Content to a specified filePath
    /// </summary>
    /// <param name="filePath">Enter the filepath with extension (eg. C:\Projects\myfile.json</param>
    /// <param name="content">Enter your content as a string</param>
    /// <returns>return true if saved, else false if failed</returns>
    bool SaveContentToFile(string filePath, string content);

    /// <summary>
    /// Get content as string from a specified filepath
    /// </summary>
    /// <param name="filePath">Enter the filepath with extension (eg. C:\Projects\myfile.json</param>
    /// <returns>returns file content as string if file exists, else returns null</returns>
    string GetContentFromFile(string filePath);
}
