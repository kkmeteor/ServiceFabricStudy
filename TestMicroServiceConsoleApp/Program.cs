using Microsoft.ServiceFabric.Services.Remoting;
using Microsoft.ServiceFabric.Services.Remoting.Client;
using Stateless1;
using System;
using MetaDataTransferModels;

namespace TestMicroServiceConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var client = ServiceProxy.Create<IJsonTestService>(new Uri("fabric:/TestServiceFabricApplication/MetaDataTransferService"));
            string msg = Console.ReadLine();
            var result = client.SayHello(msg);
            Console.WriteLine(result.Result);
            string peopleJson = client.GetJsonFromObj(new People() {Age = 12, Name = "adds"}).Result;
            Console.WriteLine(peopleJson);
            var person = client.GetObjFromJson(peopleJson).Result;
            Console.ReadKey();
        }
    }
}
