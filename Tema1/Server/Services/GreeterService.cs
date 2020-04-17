using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace Server
{
    public class GreeterService : Greeter.GreeterBase
    {
        public override Task<Empty> SayHello(HelloRequest request, ServerCallContext context)
        {
            Console.WriteLine("Request name: " + request.Name);
            return Task.FromResult(new Empty());
        }
    }
}
