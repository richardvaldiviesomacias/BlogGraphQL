using System.Collections.ObjectModel;
using System.ComponentModel;
using BlogGraphQL.Services;

namespace BlogGraphQL.Models.App
{
    public class BlogModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<PostModel> Posts = new ObservableCollection<PostModel>();
        public ObservableCollection<UserModel> Users;
        public ObservableCollection<CommentModel> Comments = new ObservableCollection<CommentModel>();

        public BlogModel(UserService userService)
        {
            Users = new ObservableCollection<UserModel>(userService.GetUsers());
        }
    }
}