using System.Collections.Generic;
using System.Threading.Tasks;
using BlogGraphQL.Models.App;
using BlogGraphQL.Models.Data;
using BlogGraphQL.Services.Mapping;
using Newtonsoft.Json;

namespace BlogGraphQL.Services
{
    public class UserService
    {
        private readonly UserMapping userMapping;

        public UserService(UserMapping userMapping)
        {
            this.userMapping = userMapping;
        }

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

            var data = await userQuery.Execute<AllUsers>();
            return userMapping.ToUserModels(data.Users);
        }

        private record AllUsers
        {
            [JsonProperty("allUsers")] public List<User> Users { get; set; }
        }
    }
}