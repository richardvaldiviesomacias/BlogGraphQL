using System.Collections.Generic;
using BlogGraphQL.Models.App;
using BlogGraphQL.Models.Data;

namespace BlogGraphQL.Services
{
    public class UserService
    {
        public UserMapping UserMapping { get; set; }
        public UserService(UserMapping userMapping)
        {
            UserMapping = userMapping;
        }

        public List<UserModel> GetUsers()
        {
            //call real api
            //fake until you make it
            var users = new List<User>();
            users.AddRange(new List<User>()
            {
                new User
                {
                    Id = 1, 
                    Name = "John Doe"
                },
                new User
                {
                    Id = 2, 
                    Name = "Samantha Doe"
                }
            });
            
            return UserMapping.ToUserModels(users);
            
        }
    }
}