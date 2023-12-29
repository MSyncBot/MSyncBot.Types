using System.Text.Json.Serialization;
using MSyncBot.Types.Enums;

namespace MSyncBot.Types;

[method: JsonConstructor]
public class File(string name, string extension, byte[] data, FileType fileType)
{
    public string Name { get; set; } = name;
    public string Extension { get; set; } = extension;
    public byte[] Data { get; set; } = data;
    public FileType Type { get; set; } = fileType;
}