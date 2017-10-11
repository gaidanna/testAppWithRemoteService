using System.Collections.Generic;
using Model.Dto;

namespace ExternalApplication
{
    public class ExternalService : IExternalService
    {
        public User GetUser(int id)
        {
            List<User> UsersList = new List<User>();

            // Instead of getting data from db.
            UsersList.Add(new User(1) { Name = "John" });
            UsersList.Add(new User(2) { Name = "Dan" });
            UsersList.Add(new User(3) { Name = "Alan" });
            UsersList.Add(new User(4) { Name = "Jeff" });
            UsersList.Add(new User(5) { Name = "Ivan" });
            UsersList.Add(new User(6) { Name = "Sam" });
            UsersList.Add(new User(7) { Name = "Ron" });
            return UsersList.Find(item => item.Id == id);
        }
    }
}
