namespace MudBlazorChatbot.Models;

public class ChatBubble
{
    public string? ThinkText { get; init; }
    public string? ResponseText { get; init; }
    public string? PromptText { get; init; }
    public bool IsUser { get; init; }
}