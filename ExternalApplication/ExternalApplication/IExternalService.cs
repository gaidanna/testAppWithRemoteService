using System.ServiceModel;
using Model.Dto;

namespace ExternalApplication
{
    [ServiceContract]
    public interface IExternalService
    {
        [OperationContract]
        User GetUser(int id);
    }
}
