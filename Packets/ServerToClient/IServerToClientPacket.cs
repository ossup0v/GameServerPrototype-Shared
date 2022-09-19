﻿using MessagePack;

namespace ServerPrototype.Shared.Packets.ServerToClient
{
    [Union(0, typeof(LoginConfirmPacket))]
    [Union(1, typeof(LoginDenyPacket))]
    [Union(2, typeof(StartBuildFarmConstructionResponsePacket))]
    public interface IServerToClientPacket : IEquatable<IServerToClientPacket>
    {
        string ToString();
    }
}