using System;
using System.Buffers;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Protocol;
using Microsoft.Extensions.Options;

namespace KuzCode.SignalR.Protocols.BlazorPack
{
    public class BlazorPackHubProtocol : IHubProtocol
    {
        private MessagePackHubProtocol _protocol;

        public string Name => "blazorpack";
        public int Version => _protocol.Version;
        public TransferFormat TransferFormat => _protocol.TransferFormat;

        public BlazorPackHubProtocol(IOptions<MessagePackHubProtocolOptions> options)
        {
            _protocol = new(options);
        }

        public BlazorPackHubProtocol() : this(Options.Create(new MessagePackHubProtocolOptions())) { }

        public bool IsVersionSupported(int version) => _protocol.IsVersionSupported(version);

        public bool TryParseMessage(ref ReadOnlySequence<byte> input, IInvocationBinder binder, out HubMessage message)
            => _protocol.TryParseMessage(ref input, binder, out message);

        public void WriteMessage(HubMessage message, IBufferWriter<byte> output)
            => _protocol.WriteMessage(message, output);

        public ReadOnlyMemory<byte> GetMessageBytes(HubMessage message) => _protocol.GetMessageBytes(message);
    }
}
