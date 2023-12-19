using MSyncBot.Types.Enums;

namespace MSyncBot.Types;

public class Message(string senderName, int senderId, SenderType senderType, MessageType messageType, User user)
{
    private static int messageIdCounter;
    public string SenderName { get; set; } = senderName;
    public int SenderId { get; set; } = senderId;
    public SenderType SenderType { get; set; } = senderType;
    public DateTime Timestamp { get; set; } = DateTime.Now;
    public int MessageId { get; set; } = GenerateMessageId();
    public string? Content { get; set; }
    public User User { get; set; } = user;

    public MessageType MessageType { get; set; } = messageType;
    public List<MediaFile> MediaFiles { get; set; } = new();

    private static int GenerateMessageId()
    {
        return messageIdCounter++;
    }
}