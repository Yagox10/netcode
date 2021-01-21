using System;
using System.Net.Sockets;
using System.Net;

namespace ServerApplication
{
    class Network
    {
        public TcpListener ServerSocket;
        public static Network instance = new Network();
        public static Client[] Clients = new Client[100];

        public void ServerStart()
        {
            for(int i = 1; i < 100; i++)
            {
                Clients[i] = new Client();
            }

            ServerSocket = new TcpListener(IPAddress.Any, 5500);
            ServerSocket.Start();
            ServerSocket.BeginAcceptTcpClient();
        }

        void OnClientConnect(IAsyncResult result)
        {
            TcpClient client = ServerSocket.EndAcceptTcpClient(result);
            client.NoDelay = false;
            ServerSocket.BeginAcceptTcpClient(OnClientConnect, null);


        }
    }
}
