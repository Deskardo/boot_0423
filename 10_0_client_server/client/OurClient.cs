using System.Net.Sockets;
using System.Text;

namespace Client
{
  class OurClient
  {
    private TcpClient client;
    StreamWriter sReader;

    OurClient(string ipaddress, int portNum)
    {
      client = new TcpClient("127.0.0.1", 5555);
      sReader = StreamWriter(client.GetStrem(), Encoding.UTF8);
    }

    void HandleCommunication()
    {
      while (true)
      {
        Console.Write("> ");
        string message = Console.ReadLine();
        sReader.WriteLine(message);
        sReader.Flush();
      }
    }
  }
}