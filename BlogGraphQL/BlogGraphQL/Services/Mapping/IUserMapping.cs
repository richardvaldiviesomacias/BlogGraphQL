using System.Collections.Generic;
using BlogGraphQL.Models.App;
using BlogGraphQL.Models.Data;

namespace BlogGraphQL.Services.Mapping
{
    public interface IUserMapping
    {
        UserModel ToUserModel(User user);
        User ToUser(UserModel userModel);
        List<UserModel> ToUserModels(IEnumerable<User> users);
    }
}