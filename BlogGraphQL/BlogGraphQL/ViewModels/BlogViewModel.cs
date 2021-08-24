using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using BlogGraphQL.Models.App;

namespace BlogGraphQL.ViewModels
{
    public class BlogViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public BlogModel BlogModel { get; set; }

        public ObservableCollection<PostViewModel> PostViewModels { get; set; } =
            new();

        public ObservableCollection<UserViewModel> UserViewModels { get; set; } =
            new();

        public ObservableCollection<CommentViewModel> CommentViewModels { get; set; } =
            new();

        public BlogViewModel(BlogModel blogModel)
        {
            BlogModel = blogModel;
            blogModel.Posts.ToList().ForEach(postModel =>
            {
                var postViewModel = new PostViewModel(postModel);
                PostViewModels.Add(postViewModel);
            });
            blogModel.Comments.ToList().ForEach(commentModel =>
            {
                var commentViewModel = new CommentViewModel(commentModel);
                CommentViewModels.Add(commentViewModel);
            });
            blogModel.Users?.ToList().ForEach(userModel =>
            {
                var userViewModel = new UserViewModel(userModel);
                UserViewModels.Add(userViewModel);
            });
            blogModel.PropertyChanged += (_, e) => PropertyChanged?.Invoke(this, e);
        }

        public void InitializeUsers()
        {
            BlogModel.Users?.ToList().ForEach(userModel =>
            {
                var userViewModel = new UserViewModel(userModel);
                UserViewModels.Add(userViewModel);
            });
        }
    }
}