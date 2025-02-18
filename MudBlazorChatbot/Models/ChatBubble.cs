namespace MudBlazorChatbot.Models;

public class ChatBubble
{
    public string? ThinkText { get; init; }
    public string? ResponseText { get; init; }
    public string? PromptText { get; init; }
    public bool IsUser { get; init; }

    public string GetClass() => IsUser ? "chat-bubble chat-bubble-user" : "chat-bubble chat-bubble-bot";
}