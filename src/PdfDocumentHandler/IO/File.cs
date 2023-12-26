using Microsoft.VisualBasic.FileIO;


namespace PdfDocumentHandler.IO;

public class File
{
    public static bool Move(string sourceFullPath, string destinationFullPath, bool overwrite)
    {
        if (Copy(sourceFullPath, destinationFullPath, overwrite))
        {
            FileSystem.DeleteFile(sourceFullPath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
            return true;
        }

        return false;
    }


    public static bool Copy(string sourceFullPath, string destinationFullPath, bool overwrite)
    {
        if (string.IsNullOrEmpty(sourceFullPath) || string.IsNullOrEmpty(destinationFullPath))
        {
            return false;
        }

        var directoryName = Path.GetDirectoryName(destinationFullPath);

        if (!string.IsNullOrEmpty(directoryName))
        {
            Directory.CreateDirectory(directoryName);
        }

        System.IO.File.Copy(sourceFullPath, destinationFullPath, overwrite);

        return true;
    }
}
