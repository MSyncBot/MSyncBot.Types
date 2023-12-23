namespace MSyncBot.Types;

public class User(
    string firstName,
    ulong id,
    string avatarUrl,
    string? lastName = null,
    string? username = null)
{
    public string FirstName { get; set; } = firstName;
    public ulong Id { get; set; } = id;
    public string AvatarUrl { get; set; } = avatarUrl;
    public string? LastName { get; set; } = lastName;
    public string? Username { get; set; } = username;
}