using System.Collections.Generic;
using System.Linq;
using BlogGraphQL.Models.App;
using BlogGraphQL.Models.Data;
using Microsoft.Extensions.DependencyInjection;

namespace BlogGraphQL.Services.Mapping
{
    public static class UserMapping 
    {
        public static UserModel ToUserModel(User user)
        {
            var userService = Startup.ServiceProvider.GetService<IUserService>();
            var userModel = new UserModel(userService)
            {
                Id = user.Id,
                Name = user.Name
            };
            return userModel;
        }

        public static User ToUser(UserModel userModel)
        {
            var user = new User
            {
                Id = userModel.Id,
                Name = userModel.Name
            };
            return user;
        }

        public static List<UserModel> ToUserModels(IEnumerable<User> users)
        {
            var userModels = new List<UserModel>();
            users.ToList().ForEach(user => { userModels.Add(ToUserModel(user)); });
            return userModels;
        }
    }
}