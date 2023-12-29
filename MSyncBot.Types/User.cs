using System.Text.Json.Serialization;

namespace MSyncBot.Types;

[method: JsonConstructor]
public class User(
    string firstName,
    ulong id)
{
    public string FirstName { get; set; } = firstName;
    public ulong? Id { get; set; } = id;
    public string? LastName { get; set; }
    public string? Username { get; set; }
    public File? ProfilePhoto { get; set; }
}