using System.Threading.Tasks;
using Microsoft.ServiceFabric.Services.Remoting;

namespace MetaDataTransferModels
{
    public interface IJsonTestService:IService
    {
        Task<string> GetJsonFromObj(People obj);
        Task<People> GetObjFromJson(string json);
        Task<string> SayHello(string msg);
    }
}
