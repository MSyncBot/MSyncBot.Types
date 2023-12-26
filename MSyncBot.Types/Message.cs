using MSyncBot.Types.Enums;

namespace MSyncBot.Types;

public class Message(Messenger messenger, MessageType messageType, User user, Chat chat)
{
    public Messenger Messenger { get; set; } = messenger;
    public User User { get; set; } = user;
    public Chat Chat { get; set; } = chat;
    public int MessageId { get; set; } = GenerateMessageId();
    public string? Content { get; set; }
    public MessageType MessageType { get; set; } = messageType;
    public List<File> MediaFiles { get; set; } = [];
    public DateTime Timestamp { get; set; } = DateTime.Now;
    
    private static int _messageIdCounter;
    private static int GenerateMessageId() => _messageIdCounter++;
}