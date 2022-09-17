using MessagePack;
using ServerPrototype.Shared.Packets.ClientToServer;

namespace ServerPrototype.Shared
{
    [MessagePackObject]
    public class StartBuildFarmConstructionPacket : IClientToServerPacket
    {
        public StartBuildFarmConstructionPacket() { }

        public StartBuildFarmConstructionPacket(Point point, int constructionId)
        {
            Point = point;
            ConstructionId = constructionId;
        }

        [Key(0)]
        public Point Point { get; set; }
        [Key(1)]
        public int ConstructionId { get; set;  }

        public override string ToString()
        {
            return $"{GetType().Name} {nameof(Point)}: {Point} {nameof(ConstructionId)}: {ConstructionId}";
        }

        public bool Equals(IClientToServerPacket other)
        {
            var packet = other as StartBuildFarmConstructionPacket;
            if (packet == null)
                return false;
            return ConstructionId == packet.ConstructionId && Point.Equals(packet.Point); 
        }
    }
}
