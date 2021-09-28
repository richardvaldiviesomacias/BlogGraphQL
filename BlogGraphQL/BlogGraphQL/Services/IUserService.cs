using System.Collections.Generic;
using System.Threading.Tasks;
using BlogGraphQL.Models.App;

namespace BlogGraphQL.Services
{
    public interface IUserService
    {
        Task<List<UserModel>> GetUsers();
        Task<UserModel> AddUser(string name);
    }
}