using System.Text.Json.Serialization;
using MSyncBot.Types.Enums;

namespace MSyncBot.Types;

[method: JsonConstructor]
public class Messenger(string name, MessengerType messengerType)
{
    public string Name { get; set; } = name;
    public MessengerType Type { get; set; } = messengerType;
    public int Id { get; } = GenerateMessengerId();
    
    private static int _idCounter;
    private static int GenerateMessengerId() => _idCounter++;
}