using Microsoft.ServiceFabric.Services.Remoting.Client;
using System;
using MetaDataTransferModels;
using System.Threading.Tasks;

namespace TestMicroServiceConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var client = ServiceProxy.Create<IJsonTestService>(new Uri("fabric:/MetaDataTransferServiceFabricApplication/MetaDataTransferTool"));
            var client2 = ServiceProxy.Create<IJsonTestService>(new Uri("fabric:/TestServiceFabricApplication/MetaDataTransferService"));

            var result1 = client.SayHello("Yutong");
            var result2 = client2.SayHello("Tengfei");

            Console.WriteLine(result1.Result);
            Console.WriteLine(result2.Result);
            string msg = Console.ReadLine();
            var result = client.SayHello(msg);
            Console.WriteLine(result.Result);
            string peopleJson = client.GetJsonFromObj(new People() { Age = 12, Name = "adds" }).Result;
            Console.WriteLine(peopleJson);
            var person = client.GetObjFromJson(peopleJson).Result;
            Console.ReadKey();
        }
    }
}
