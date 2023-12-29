using System.Text.Json.Serialization;
using MSyncBot.Types.Enums;

namespace MSyncBot.Types;

[method: JsonConstructor]
public class Message(Messenger messenger, MessageType messageType, User user, Chat chat)
{
    public Messenger Messenger { get; set; } = messenger;
    public User User { get; set; } = user;
    public Chat Chat { get; set; } = chat;
    public int Id { get; set; } = GenerateMessageId();
    public string? Text { get; set; }
    public MessageType Type { get; set; } = messageType;
    public List<File> Files { get; set; } = [];
    public DateTime Timestamp { get; set; } = DateTime.Now;
    
    private static int _messageIdCounter;
    private static int GenerateMessageId() => _messageIdCounter++;
}