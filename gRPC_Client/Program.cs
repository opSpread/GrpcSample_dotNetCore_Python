using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using Google.Protobuf;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Channels;
using Grpc.Core;

namespace gRPC_Client
{
    class Program
    {

        public static async Task Main(string[] args)
        {
            AppContext.SetSwitch(
           "System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);

            using var channel = GrpcChannel.ForAddress("http://127.0.0.1:50051");
            var client = new Greeter.GreeterClient(channel);

            var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient1" });



            Console.WriteLine($"Greetings: {reply.Message}");
            Console.WriteLine("press any key to exit");
            Console.ReadLine();


        }
    }
}
