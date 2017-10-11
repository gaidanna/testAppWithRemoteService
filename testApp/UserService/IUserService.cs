using Model.Dto;
using System.ServiceModel;

namespace UserService
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        UserDto GetUser(int id);
    }
}
