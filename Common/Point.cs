using MessagePack;

namespace ServerPrototype.Shared
{
    [MessagePackObject]
    public struct Point
    {
        [Key(0)]
        public int X { get; set; }
        [Key(1)]
        public int Y { get; set; }
    }
}
