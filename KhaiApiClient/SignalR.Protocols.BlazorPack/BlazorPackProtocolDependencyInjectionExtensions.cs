using KuzCode.SignalR.Protocols.BlazorPack;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Protocol;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class BlazorPackProtocolDependencyInjectionExtensions
    {
        public static TBuilder AddBlazorPackProtocol<TBuilder>(this TBuilder builder) where TBuilder : ISignalRBuilder
            => builder.AddBlazorPackProtocol(_ => { });

        public static TBuilder AddBlazorPackProtocol<TBuilder>(this TBuilder builder, Action<MessagePackHubProtocolOptions> configure)
            where TBuilder : ISignalRBuilder
        {
            builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton<IHubProtocol, BlazorPackHubProtocol>());
            builder.Services.Configure(configure);

            return builder;
        }
    }
}
