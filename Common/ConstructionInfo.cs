using MessagePack;

namespace ServerPrototype.Shared;

[MessagePackObject]
public class ConstructionInfo
{
    [Key(0)]
    public int Id { get; set; }
    [Key(1)]
    public Point Point { get; set; }
    [Key(2)]
    public int Level { get; set; }
}