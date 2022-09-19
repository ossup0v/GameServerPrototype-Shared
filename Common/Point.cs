using MessagePack;

namespace ServerPrototype.Shared
{
    [MessagePackObject]
    [Serializable]
    public struct Point
    {
        [Key(0)]
        public int X { get; set; }
        [Key(1)]
        public int Y { get; set; }

        public override string ToString()
        {
            return $"X:{X} Y:{Y}";
        }
    }
}
