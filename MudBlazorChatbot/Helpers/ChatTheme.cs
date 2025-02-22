using MudBlazor;
using MudBlazor.Utilities;

namespace MudBlazorChatbot.Helpers;

public static class ChatTheme
{
    public static MudTheme GetTheme => new()
    {
        PaletteDark = DarkPalette()
    };

    private static PaletteDark DarkPalette()
    {
        return new PaletteDark
        {
            Primary = new MudColor("#22a6b3"),
            Secondary = new MudColor("#f0932b"),
            Tertiary = new MudColor("#6ab04c"),
            Info = new MudColor("#22a6b3"),
            Success = new MudColor("#6ab04c"),
            Warning = new MudColor("#f9ca24"),
            Error = new MudColor("#eb4d4b")
        };
    }
}