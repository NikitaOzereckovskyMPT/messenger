using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class TcpClient
{
    private System.Net.Sockets.TcpClient client;
    private CancellationTokenSource cts;

    public TcpClient()
    {
        client = new System.Net.Sockets.TcpClient();
    }

    public async Task ConnectAsync(string serverIP)
    {
        cts = new CancellationTokenSource();

        await client.ConnectAsync(serverIP, 5000);
    }

    public void Disconnect()
    {
        cts.Cancel();
        client.Close();
    }
}