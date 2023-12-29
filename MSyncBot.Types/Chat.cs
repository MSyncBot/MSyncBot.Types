using System.Text.Json.Serialization;

namespace MSyncBot.Types;

[method: JsonConstructor]
public class Chat(string name, ulong id)
{
    public string Name { get; set; } = name;
    public ulong Id { get; set; } = id;
    public string? InviteLink { get; set; }
    public File? Photo { get; set; }
}