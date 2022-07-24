using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzCode.KhaiApiClient
{
    public class KhaiClient
    {
        private HubConnection _hubConnection;

        public KhaiClient()
        {
            _hubConnection = new HubConnectionBuilder()
                .WithUrl(Khai.EducationSocketsUrl + "_blazor", configuration =>
                {
                    configuration.SkipNegotiation = false;
                    configuration.Transports = HttpTransportType.WebSockets;
                })
                .AddBlazorPackProtocol()
                .WithAutomaticReconnect(Enumerable.Repeat(TimeSpan.FromMilliseconds(500), 10).ToArray())
                .ConfigureLogging(logging =>
                {
                    logging.AddConsole();
                    logging.SetMinimumLevel(LogLevel.Trace);
                })
                .Build();

            _hubConnection.On("JS.BeginInvokeJS", () =>
            {
                Console.WriteLine("S");
            });

            _hubConnection.On<long, string>("JS.RenderBatch", (rendererId, batchBase64) =>
            {
                var data = Convert.FromBase64String(batchBase64);
                var decodedString = Encoding.UTF8.GetString(data);
            });
        }

        public async Task ConnectAsync()
        {
            await _hubConnection.StartAsync();
            //await _hubConnection.SendAsync("BeginInvokeDotNetFromJS", "2", "DispatchEventAsync", "change", "10",
            //    @"[{ ""eventHandlerId"" = 2, ""eventName"" = ""change"", ""eventFieldInfo"" = { ""componentId"" = 10, ""fieldValue"" = ""611p"" } }, { value = ""611p"" } ]");
        }

        public async Task DisconnectAsync() => await _hubConnection.StopAsync();
    }
}
