namespace NucAIChat.Models
{
    public class ChatMessageModel
    {
        public string Content { get; set; } = string.Empty;
        public bool IsUser { get; set; }
        public bool IsVisible { get; set; } = true; 
    }
}