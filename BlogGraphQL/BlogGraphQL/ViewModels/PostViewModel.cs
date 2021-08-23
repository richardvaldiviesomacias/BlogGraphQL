using System.ComponentModel;
using BlogGraphQL.Models.App;

namespace BlogGraphQL.ViewModels
{
    public class PostViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public readonly PostModel PostModel;
        public long Id => PostModel.Id;
        public string Title => PostModel.Title;
        public long Views => PostModel.Views;
        public long UserId => PostModel.UserId;
        public PostViewModel(PostModel postModel)
        {
            PostModel = postModel;
            postModel.PropertyChanged += (o, e) => PropertyChanged?.Invoke(this, e); 
        }
        
    }
}