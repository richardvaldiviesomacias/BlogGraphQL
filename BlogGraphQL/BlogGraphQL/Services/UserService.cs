using System.Collections.Generic;
using System.Threading.Tasks;
using BlogGraphQL.Models.App;
using BlogGraphQL.Models.Data;
using BlogGraphQL.Services.Mapping;
using Newtonsoft.Json;

namespace BlogGraphQL.Services
{
    public class UserService : IUserService
    {
        public async Task<List<UserModel>> GetUsers()
        {
            //call real api
            //fake until you make it
            var userQuery = new GraphQLQuery
            (
                @"{
                     allUsers {
                      id
                      name
                    }
                  }"
            );

            var data = await userQuery.Execute<GetAllUsers>();
            return UserMapping.ToUserModels(data.Users);
        }

        public async Task<UserModel> AddUser(string name)
        {
            var userQuery = new GraphQLQuery
            (
                "mutation" +
                $"{{createUser(name:\"{ name }\") " +
                "{id name}}"
            );
            var data = await userQuery.Execute<CreateUser>();
            return UserMapping.ToUserModel(data.User);
        }

        private record GetAllUsers
        {
            [JsonProperty("allUsers")] public List<User> Users { get; set; }
        }
        
        private record CreateUser
        {
            [JsonProperty("createUser")] public User User { get; set; }
        }
    }
}