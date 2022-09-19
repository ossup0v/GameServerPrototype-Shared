using MessagePack;

namespace ServerPrototype.Shared.Packets.ServerToClient
{
    [MessagePackObject]
    public sealed class StartBuildFarmConstructionResponsePacket : IServerToClientPacket
    {
        [Key(0)]
        public int BuildDurationSecond { get; set; }

        public bool Equals(IServerToClientPacket other)
        {
            return Equals(other as object);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((StartBuildFarmConstructionResponsePacket)obj);
        }
    }
}
