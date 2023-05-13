using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class TcpServer
{
    private TcpListener listener;
    private CancellationTokenSource cts;

    public TcpServer()
    {
        listener = new TcpListener(IPAddress.Any, 5000);
    }

    public async Task StartAsync()
    {
        cts = new CancellationTokenSource();

        listener.Start();

        while (true)
        {
            if (cts.Token.IsCancellationRequested)
            {
                listener.Stop();
                break;
            }

            var client = await listener.AcceptTcpClientAsync();
        }
    }

    public void Stop()
    {
        cts.Cancel();
    }
}
