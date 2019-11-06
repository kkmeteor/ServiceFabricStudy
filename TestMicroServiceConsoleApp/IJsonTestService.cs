using Microsoft.ServiceFabric.Services.Remoting;
using System.Threading.Tasks;

namespace TestMicroServiceConsoleApp
{
    public interface IJsonTestService : IService
    {
        //Task<string> GetJsonFromObj(People obj);
        //Task<People> GetObjFromJson(string json);
        Task<string> SayHello(string msg);
    }
}