using Grpc.Net.Client;
using Server;
using System;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var input = new HelloRequest { Name = Console.ReadLine() };

            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);

            await client.SayHelloAsync(input);

            

            Console.ReadLine();
        }
    }
}
