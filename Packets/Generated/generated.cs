// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY MPC(MessagePack-CSharp). DO NOT CHANGE IT.
// </auto-generated>

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
#pragma warning disable CS1591 // document public APIs

#pragma warning disable SA1312 // Variable names should begin with lower-case letter
#pragma warning disable SA1649 // File name should match first type name

namespace MessagePack.Resolvers
{
    public class GeneratedResolver : global::MessagePack.IFormatterResolver
    {
        public static readonly global::MessagePack.IFormatterResolver Instance = new GeneratedResolver();

        private GeneratedResolver()
        {
        }

        public global::MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>()
        {
            return FormatterCache<T>.Formatter;
        }

        private static class FormatterCache<T>
        {
            internal static readonly global::MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

            static FormatterCache()
            {
                var f = GeneratedResolverGetFormatterHelper.GetFormatter(typeof(T));
                if (f != null)
                {
                    Formatter = (global::MessagePack.Formatters.IMessagePackFormatter<T>)f;
                }
            }
        }
    }

    internal static class GeneratedResolverGetFormatterHelper
    {
        private static readonly global::System.Collections.Generic.Dictionary<global::System.Type, int> lookup;

        static GeneratedResolverGetFormatterHelper()
        {
            lookup = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(6)
            {
                { typeof(global::ServerPrototype.Shared.Packets.ClientToServer.IClientToServerPacket), 0 },
                { typeof(global::ServerPrototype.Shared.Packets.ServerToClient.IServerToClientPacket), 1 },
                { typeof(global::ServerPrototype.Shared.Packets.ServerToClient.PlayerProfileInfo), 2 },
                { typeof(global::ServerPrototype.Shared.Packets.ClientToServer.LoginPacket), 3 },
                { typeof(global::ServerPrototype.Shared.Packets.ServerToClient.LoginConfirmPacket), 4 },
                { typeof(global::ServerPrototype.Shared.Packets.ServerToClient.LoginDenyPacket), 5 },
            };
        }

        internal static object GetFormatter(global::System.Type t)
        {
            int key;
            if (!lookup.TryGetValue(t, out key))
            {
                return null;
            }

            switch (key)
            {
                case 0: return new MessagePack.Formatters.ServerPrototype.Shared.Packets.ClientToServer.IClientToServerPacketFormatter();
                case 1: return new MessagePack.Formatters.ServerPrototype.Shared.Packets.ServerToClient.IServerToClientPacketFormatter();
                case 2: return new MessagePack.Formatters.ServerPrototype.Shared.Packets.ServerToClient.PlayerProfileInfoFormatter();
                case 3: return new MessagePack.Formatters.ServerPrototype.Shared.Packets.ClientToServer.LoginPacketFormatter();
                case 4: return new MessagePack.Formatters.ServerPrototype.Shared.Packets.ServerToClient.LoginConfirmPacketFormatter();
                case 5: return new MessagePack.Formatters.ServerPrototype.Shared.Packets.ServerToClient.LoginDenyPacketFormatter();
                default: return null;
            }
        }
    }
}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning restore SA1312 // Variable names should begin with lower-case letter
#pragma warning restore SA1649 // File name should match first type name



// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY MPC(MessagePack-CSharp). DO NOT CHANGE IT.
// </auto-generated>

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
#pragma warning disable CS1591 // document public APIs

#pragma warning disable SA1403 // File may only contain a single namespace
#pragma warning disable SA1649 // File name should match first type name

namespace MessagePack.Formatters.ServerPrototype.Shared.Packets.ClientToServer
{
    public sealed class IClientToServerPacketFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::ServerPrototype.Shared.Packets.ClientToServer.IClientToServerPacket>
    {
        private readonly global::System.Collections.Generic.Dictionary<global::System.RuntimeTypeHandle, global::System.Collections.Generic.KeyValuePair<int, int>> typeToKeyAndJumpMap;
        private readonly global::System.Collections.Generic.Dictionary<int, int> keyToJumpMap;

        public IClientToServerPacketFormatter()
        {
            this.typeToKeyAndJumpMap = new global::System.Collections.Generic.Dictionary<global::System.RuntimeTypeHandle, global::System.Collections.Generic.KeyValuePair<int, int>>(2, global::MessagePack.Internal.RuntimeTypeHandleEqualityComparer.Default)
            {
                { typeof(global::ServerPrototype.Shared.Packets.ClientToServer.LoginPacket).TypeHandle, new global::System.Collections.Generic.KeyValuePair<int, int>(0, 0) },
                { typeof(global::ServerPrototype.Shared.StartBuildFarmConstructionPacket).TypeHandle, new global::System.Collections.Generic.KeyValuePair<int, int>(1, 1) },
            };
            this.keyToJumpMap = new global::System.Collections.Generic.Dictionary<int, int>(2)
            {
                { 0, 0 },
                { 1, 1 },
            };
        }

        public void Serialize(ref global::MessagePack.MessagePackWriter writer, global::ServerPrototype.Shared.Packets.ClientToServer.IClientToServerPacket value, global::MessagePack.MessagePackSerializerOptions options)
        {
            global::System.Collections.Generic.KeyValuePair<int, int> keyValuePair;
            if (value != null && this.typeToKeyAndJumpMap.TryGetValue(value.GetType().TypeHandle, out keyValuePair))
            {
                writer.WriteArrayHeader(2);
                writer.WriteInt32(keyValuePair.Key);
                switch (keyValuePair.Value)
                {
                    case 0:
                        options.Resolver.GetFormatterWithVerify<global::ServerPrototype.Shared.Packets.ClientToServer.LoginPacket>().Serialize(ref writer, (global::ServerPrototype.Shared.Packets.ClientToServer.LoginPacket)value, options);
                        break;
                    case 1:
                        options.Resolver.GetFormatterWithVerify<global::ServerPrototype.Shared.StartBuildFarmConstructionPacket>().Serialize(ref writer, (global::ServerPrototype.Shared.StartBuildFarmConstructionPacket)value, options);
                        break;
                    default:
                        break;
                }

                return;
            }

            writer.WriteNil();
        }

        public global::ServerPrototype.Shared.Packets.ClientToServer.IClientToServerPacket Deserialize(ref global::MessagePack.MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (reader.TryReadNil())
            {
                return null;
            }

            if (reader.ReadArrayHeader() != 2)
            {
                throw new global::System.InvalidOperationException("Invalid Union data was detected. Type:global::ServerPrototype.Shared.Packets.ClientToServer.IClientToServerPacket");
            }

            options.Security.DepthStep(ref reader);
            var key = reader.ReadInt32();

            if (!this.keyToJumpMap.TryGetValue(key, out key))
            {
                key = -1;
            }

            global::ServerPrototype.Shared.Packets.ClientToServer.IClientToServerPacket result = null;
            switch (key)
            {
                case 0:
                    result = (global::ServerPrototype.Shared.Packets.ClientToServer.IClientToServerPacket)options.Resolver.GetFormatterWithVerify<global::ServerPrototype.Shared.Packets.ClientToServer.LoginPacket>().Deserialize(ref reader, options);
                    break;
                case 1:
                    result = (global::ServerPrototype.Shared.Packets.ClientToServer.IClientToServerPacket)options.Resolver.GetFormatterWithVerify<global::ServerPrototype.Shared.StartBuildFarmConstructionPacket>().Deserialize(ref reader, options);
                    break;
                default:
                    reader.Skip();
                    break;
            }

            reader.Depth--;
            return result;
        }
    }


}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning restore SA1403 // File may only contain a single namespace
#pragma warning restore SA1649 // File name should match first type name

// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY MPC(MessagePack-CSharp). DO NOT CHANGE IT.
// </auto-generated>

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
#pragma warning disable CS1591 // document public APIs

#pragma warning disable SA1403 // File may only contain a single namespace
#pragma warning disable SA1649 // File name should match first type name

namespace MessagePack.Formatters.ServerPrototype.Shared.Packets.ServerToClient
{
    public sealed class IServerToClientPacketFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::ServerPrototype.Shared.Packets.ServerToClient.IServerToClientPacket>
    {
        private readonly global::System.Collections.Generic.Dictionary<global::System.RuntimeTypeHandle, global::System.Collections.Generic.KeyValuePair<int, int>> typeToKeyAndJumpMap;
        private readonly global::System.Collections.Generic.Dictionary<int, int> keyToJumpMap;

        public IServerToClientPacketFormatter()
        {
            this.typeToKeyAndJumpMap = new global::System.Collections.Generic.Dictionary<global::System.RuntimeTypeHandle, global::System.Collections.Generic.KeyValuePair<int, int>>(2, global::MessagePack.Internal.RuntimeTypeHandleEqualityComparer.Default)
            {
                { typeof(global::ServerPrototype.Shared.Packets.ServerToClient.LoginConfirmPacket).TypeHandle, new global::System.Collections.Generic.KeyValuePair<int, int>(0, 0) },
                { typeof(global::ServerPrototype.Shared.Packets.ServerToClient.LoginDenyPacket).TypeHandle, new global::System.Collections.Generic.KeyValuePair<int, int>(1, 1) },
            };
            this.keyToJumpMap = new global::System.Collections.Generic.Dictionary<int, int>(2)
            {
                { 0, 0 },
                { 1, 1 },
            };
        }

        public void Serialize(ref global::MessagePack.MessagePackWriter writer, global::ServerPrototype.Shared.Packets.ServerToClient.IServerToClientPacket value, global::MessagePack.MessagePackSerializerOptions options)
        {
            global::System.Collections.Generic.KeyValuePair<int, int> keyValuePair;
            if (value != null && this.typeToKeyAndJumpMap.TryGetValue(value.GetType().TypeHandle, out keyValuePair))
            {
                writer.WriteArrayHeader(2);
                writer.WriteInt32(keyValuePair.Key);
                switch (keyValuePair.Value)
                {
                    case 0:
                        options.Resolver.GetFormatterWithVerify<global::ServerPrototype.Shared.Packets.ServerToClient.LoginConfirmPacket>().Serialize(ref writer, (global::ServerPrototype.Shared.Packets.ServerToClient.LoginConfirmPacket)value, options);
                        break;
                    case 1:
                        options.Resolver.GetFormatterWithVerify<global::ServerPrototype.Shared.Packets.ServerToClient.LoginDenyPacket>().Serialize(ref writer, (global::ServerPrototype.Shared.Packets.ServerToClient.LoginDenyPacket)value, options);
                        break;
                    default:
                        break;
                }

                return;
            }

            writer.WriteNil();
        }

        public global::ServerPrototype.Shared.Packets.ServerToClient.IServerToClientPacket Deserialize(ref global::MessagePack.MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (reader.TryReadNil())
            {
                return null;
            }

            if (reader.ReadArrayHeader() != 2)
            {
                throw new global::System.InvalidOperationException("Invalid Union data was detected. Type:global::ServerPrototype.Shared.Packets.ServerToClient.IServerToClientPacket");
            }

            options.Security.DepthStep(ref reader);
            var key = reader.ReadInt32();

            if (!this.keyToJumpMap.TryGetValue(key, out key))
            {
                key = -1;
            }

            global::ServerPrototype.Shared.Packets.ServerToClient.IServerToClientPacket result = null;
            switch (key)
            {
                case 0:
                    result = (global::ServerPrototype.Shared.Packets.ServerToClient.IServerToClientPacket)options.Resolver.GetFormatterWithVerify<global::ServerPrototype.Shared.Packets.ServerToClient.LoginConfirmPacket>().Deserialize(ref reader, options);
                    break;
                case 1:
                    result = (global::ServerPrototype.Shared.Packets.ServerToClient.IServerToClientPacket)options.Resolver.GetFormatterWithVerify<global::ServerPrototype.Shared.Packets.ServerToClient.LoginDenyPacket>().Deserialize(ref reader, options);
                    break;
                default:
                    reader.Skip();
                    break;
            }

            reader.Depth--;
            return result;
        }
    }

    public sealed class PlayerProfileInfoFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::ServerPrototype.Shared.Packets.ServerToClient.PlayerProfileInfo>
    {
        private readonly global::System.Collections.Generic.Dictionary<global::System.RuntimeTypeHandle, global::System.Collections.Generic.KeyValuePair<int, int>> typeToKeyAndJumpMap;
        private readonly global::System.Collections.Generic.Dictionary<int, int> keyToJumpMap;

        public PlayerProfileInfoFormatter()
        {
            this.typeToKeyAndJumpMap = new global::System.Collections.Generic.Dictionary<global::System.RuntimeTypeHandle, global::System.Collections.Generic.KeyValuePair<int, int>>(1, global::MessagePack.Internal.RuntimeTypeHandleEqualityComparer.Default)
            {
                { typeof(global::ServerPrototype.Shared.Packets.ServerToClient.LoginConfirmPacket).TypeHandle, new global::System.Collections.Generic.KeyValuePair<int, int>(0, 0) },
            };
            this.keyToJumpMap = new global::System.Collections.Generic.Dictionary<int, int>(1)
            {
                { 0, 0 },
            };
        }

        public void Serialize(ref global::MessagePack.MessagePackWriter writer, global::ServerPrototype.Shared.Packets.ServerToClient.PlayerProfileInfo value, global::MessagePack.MessagePackSerializerOptions options)
        {
            global::System.Collections.Generic.KeyValuePair<int, int> keyValuePair;
            if (value != null && this.typeToKeyAndJumpMap.TryGetValue(value.GetType().TypeHandle, out keyValuePair))
            {
                writer.WriteArrayHeader(2);
                writer.WriteInt32(keyValuePair.Key);
                switch (keyValuePair.Value)
                {
                    case 0:
                        options.Resolver.GetFormatterWithVerify<global::ServerPrototype.Shared.Packets.ServerToClient.LoginConfirmPacket>().Serialize(ref writer, (global::ServerPrototype.Shared.Packets.ServerToClient.LoginConfirmPacket)value, options);
                        break;
                    default:
                        break;
                }

                return;
            }

            writer.WriteNil();
        }

        public global::ServerPrototype.Shared.Packets.ServerToClient.PlayerProfileInfo Deserialize(ref global::MessagePack.MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (reader.TryReadNil())
            {
                return null;
            }

            if (reader.ReadArrayHeader() != 2)
            {
                throw new global::System.InvalidOperationException("Invalid Union data was detected. Type:global::ServerPrototype.Shared.Packets.ServerToClient.PlayerProfileInfo");
            }

            options.Security.DepthStep(ref reader);
            var key = reader.ReadInt32();

            if (!this.keyToJumpMap.TryGetValue(key, out key))
            {
                key = -1;
            }

            global::ServerPrototype.Shared.Packets.ServerToClient.PlayerProfileInfo result = null;
            switch (key)
            {
                case 0:
                    result = (global::ServerPrototype.Shared.Packets.ServerToClient.PlayerProfileInfo)options.Resolver.GetFormatterWithVerify<global::ServerPrototype.Shared.Packets.ServerToClient.LoginConfirmPacket>().Deserialize(ref reader, options);
                    break;
                default:
                    reader.Skip();
                    break;
            }

            reader.Depth--;
            return result;
        }
    }


}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning restore SA1403 // File may only contain a single namespace
#pragma warning restore SA1649 // File name should match first type name


// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY MPC(MessagePack-CSharp). DO NOT CHANGE IT.
// </auto-generated>

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
#pragma warning disable CS1591 // document public APIs

#pragma warning disable SA1129 // Do not use default value type constructor
#pragma warning disable SA1309 // Field names should not begin with underscore
#pragma warning disable SA1312 // Variable names should begin with lower-case letter
#pragma warning disable SA1403 // File may only contain a single namespace
#pragma warning disable SA1649 // File name should match first type name

namespace MessagePack.Formatters.ServerPrototype.Shared.Packets.ClientToServer
{
    public sealed class LoginPacketFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::ServerPrototype.Shared.Packets.ClientToServer.LoginPacket>
    {

        public void Serialize(ref global::MessagePack.MessagePackWriter writer, global::ServerPrototype.Shared.Packets.ClientToServer.LoginPacket value, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (value == null)
            {
                writer.WriteNil();
                return;
            }

            global::MessagePack.IFormatterResolver formatterResolver = options.Resolver;
            writer.WriteArrayHeader(1);
            global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<string>(formatterResolver).Serialize(ref writer, value.ClientId, options);
        }

        public global::ServerPrototype.Shared.Packets.ClientToServer.LoginPacket Deserialize(ref global::MessagePack.MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (reader.TryReadNil())
            {
                return null;
            }

            options.Security.DepthStep(ref reader);
            global::MessagePack.IFormatterResolver formatterResolver = options.Resolver;
            var length = reader.ReadArrayHeader();
            var __ClientId__ = default(string);

            for (int i = 0; i < length; i++)
            {
                switch (i)
                {
                    case 0:
                        __ClientId__ = global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<string>(formatterResolver).Deserialize(ref reader, options);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }

            var ____result = new global::ServerPrototype.Shared.Packets.ClientToServer.LoginPacket(__ClientId__);
            reader.Depth--;
            return ____result;
        }
    }

}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning restore SA1129 // Do not use default value type constructor
#pragma warning restore SA1309 // Field names should not begin with underscore
#pragma warning restore SA1312 // Variable names should begin with lower-case letter
#pragma warning restore SA1403 // File may only contain a single namespace
#pragma warning restore SA1649 // File name should match first type name

// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY MPC(MessagePack-CSharp). DO NOT CHANGE IT.
// </auto-generated>

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
#pragma warning disable CS1591 // document public APIs

#pragma warning disable SA1129 // Do not use default value type constructor
#pragma warning disable SA1309 // Field names should not begin with underscore
#pragma warning disable SA1312 // Variable names should begin with lower-case letter
#pragma warning disable SA1403 // File may only contain a single namespace
#pragma warning disable SA1649 // File name should match first type name

namespace MessagePack.Formatters.ServerPrototype.Shared.Packets.ServerToClient
{
    public sealed class LoginConfirmPacketFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::ServerPrototype.Shared.Packets.ServerToClient.LoginConfirmPacket>
    {

        public void Serialize(ref global::MessagePack.MessagePackWriter writer, global::ServerPrototype.Shared.Packets.ServerToClient.LoginConfirmPacket value, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (value == null)
            {
                writer.WriteNil();
                return;
            }

            global::MessagePack.IFormatterResolver formatterResolver = options.Resolver;
            writer.WriteArrayHeader(7);
            writer.WriteNil();
            writer.WriteNil();
            writer.WriteNil();
            writer.WriteNil();
            global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<string>(formatterResolver).Serialize(ref writer, value.UserId, options);
            global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<int[]>(formatterResolver).Serialize(ref writer, value.Heroes, options);
            global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<string>(formatterResolver).Serialize(ref writer, value.NickName, options);
        }

        public global::ServerPrototype.Shared.Packets.ServerToClient.LoginConfirmPacket Deserialize(ref global::MessagePack.MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (reader.TryReadNil())
            {
                return null;
            }

            options.Security.DepthStep(ref reader);
            global::MessagePack.IFormatterResolver formatterResolver = options.Resolver;
            var length = reader.ReadArrayHeader();
            var ____result = new global::ServerPrototype.Shared.Packets.ServerToClient.LoginConfirmPacket();

            for (int i = 0; i < length; i++)
            {
                switch (i)
                {
                    case 4:
                        ____result.UserId = global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<string>(formatterResolver).Deserialize(ref reader, options);
                        break;
                    case 5:
                        ____result.Heroes = global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<int[]>(formatterResolver).Deserialize(ref reader, options);
                        break;
                    case 6:
                        ____result.NickName = global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<string>(formatterResolver).Deserialize(ref reader, options);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }

            reader.Depth--;
            return ____result;
        }
    }

    public sealed class LoginDenyPacketFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::ServerPrototype.Shared.Packets.ServerToClient.LoginDenyPacket>
    {

        public void Serialize(ref global::MessagePack.MessagePackWriter writer, global::ServerPrototype.Shared.Packets.ServerToClient.LoginDenyPacket value, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (value == null)
            {
                writer.WriteNil();
                return;
            }

            global::MessagePack.IFormatterResolver formatterResolver = options.Resolver;
            writer.WriteArrayHeader(1);
            global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<string>(formatterResolver).Serialize(ref writer, value.Reason, options);
        }

        public global::ServerPrototype.Shared.Packets.ServerToClient.LoginDenyPacket Deserialize(ref global::MessagePack.MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (reader.TryReadNil())
            {
                return null;
            }

            options.Security.DepthStep(ref reader);
            global::MessagePack.IFormatterResolver formatterResolver = options.Resolver;
            var length = reader.ReadArrayHeader();
            var ____result = new global::ServerPrototype.Shared.Packets.ServerToClient.LoginDenyPacket();

            for (int i = 0; i < length; i++)
            {
                switch (i)
                {
                    case 0:
                        ____result.Reason = global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<string>(formatterResolver).Deserialize(ref reader, options);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }

            reader.Depth--;
            return ____result;
        }
    }

}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning restore SA1129 // Do not use default value type constructor
#pragma warning restore SA1309 // Field names should not begin with underscore
#pragma warning restore SA1312 // Variable names should begin with lower-case letter
#pragma warning restore SA1403 // File may only contain a single namespace
#pragma warning restore SA1649 // File name should match first type name

