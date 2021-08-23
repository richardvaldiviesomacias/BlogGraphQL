using System.Collections.Generic;
using System.Linq;
using BlogGraphQL.Models.App;
using BlogGraphQL.Models.Data;

namespace BlogGraphQL.Services
{
    public class UserMapping
    {
        public UserModel ToUserModel(User user)
        {
            var userModel = new UserModel
            {
                Id = user.Id,
                Name = user.Name
            };
            return userModel;
        }

        public User ToUser(UserModel userModel)
        {
            var user = new User
            {
                Id = userModel.Id,
                Name = userModel.Name
            };
            return user;
        }

        public List<UserModel> ToUserModels(IEnumerable<User> users)
        {
            var userModels = new List<UserModel>();
            users.ToList().ForEach(user =>
            {
                userModels.Add(ToUserModel(user));
            });
            return userModels;
        }
    }
}