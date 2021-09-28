using System.ComponentModel;
using System.Threading.Tasks;
using BlogGraphQL.Services;

namespace BlogGraphQL.Models.App
{
    public class UserModel: INotifyPropertyChanged
    {
        private readonly IUserService service;
        public event PropertyChangedEventHandler PropertyChanged;
        public long Id { get; set; }
        public string Name { get; set; }

        public UserModel(IUserService service)
        {
            this.service = service;
        }

        public async Task<UserModel> Save(string name)
        {
            return await service.AddUser(name);
        }
    }
}