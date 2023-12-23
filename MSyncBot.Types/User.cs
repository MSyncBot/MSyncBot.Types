namespace MSyncBot.Types;

public class User(
    string firstName,
    string? lastName = null,
    string? username = null,
    ulong? id = null,
    string? avatarUrl = null)
{
    public string FirstName { get; set; } = firstName;
    public string? LastName { get; set; } = lastName;
    public string? Username { get; set; } = username;
    public ulong? Id { get; set; } = id;
    public string? AvatarUrl { get; set; } = avatarUrl;
}