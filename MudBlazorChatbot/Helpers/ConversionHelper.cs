namespace MudBlazorChatbot.Helpers;

public static class ConversionHelper
{
    public static string ConvertFileLengthToString(long fileLength)
    {
        string[] sizes = ["B", "KB", "MB", "GB", "TB"];
        var order = 0;
        var fileSize = (double)fileLength;
        while (fileSize >= 1024 && order < sizes.Length - 1)
        {
            order++;
            fileSize /= 1024;
        }

        return $"{fileSize:0.#} {sizes[order]}";
    }
}