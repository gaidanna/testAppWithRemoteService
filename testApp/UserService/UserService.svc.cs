using System;
using Model.Dto;

namespace UserService
{
    public class UserService : IUserService
    {
        public UserDto GetUser(int id)
        {
            string exceptionMessage;

            UserDto result;
            ExtService.ExternalServiceClient client;
            exceptionMessage = "Exception caught: {0}";

            result = null;
            try
            {
                client = new ExtService.ExternalServiceClient();
                var user = client.GetUser(id);
                result = new UserDto(user.Id);
                result.Name = user.Name;
            }
            catch ( Exception ex ) 
            {
                Console.WriteLine(exceptionMessage, ex.Message);    
            }
            return result;
        }
    }
}
