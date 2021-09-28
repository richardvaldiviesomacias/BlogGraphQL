using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using BlogGraphQL.Services;

namespace BlogGraphQL.Models.App
{
    public class BlogModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly IUserService userService;
        public ObservableCollection<PostModel> Posts = new ObservableCollection<PostModel>();
        public ObservableCollection<UserModel> Users;
        public ObservableCollection<CommentModel> Comments = new ObservableCollection<CommentModel>();

        public async Task InitializeAsync()
        {
            Users = new ObservableCollection<UserModel>(await userService.GetUsers());
        }

        public BlogModel(IUserService userService)
        {
            this.userService = userService;
        }
    }
}