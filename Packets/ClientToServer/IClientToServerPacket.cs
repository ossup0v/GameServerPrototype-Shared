using MessagePack;
namespace ServerPrototype.Shared.Packets.ClientToServer
{
    [Union(0, typeof(LoginPacket))]
    [Union(1, typeof(StartBuildFarmConstructionPacket))]
    public interface IClientToServerPacket : IEquatable<IClientToServerPacket>
    {
        string ToString();
    }
}
