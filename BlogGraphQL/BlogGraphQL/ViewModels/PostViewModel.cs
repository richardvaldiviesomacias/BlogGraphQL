using System.ComponentModel;
using BlogGraphQL.Models.App;

namespace BlogGraphQL.ViewModels
{
    public class PostViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly PostModel postModel;
        public long Id => postModel.Id;
        public string Title => postModel.Title;
        public long Views => postModel.Views;
        public long UserId => postModel.UserId;

        public PostViewModel(PostModel postModel)
        {
            this.postModel = postModel;
            postModel.PropertyChanged += (_, e) => PropertyChanged?.Invoke(this, e);
        }
    }
}