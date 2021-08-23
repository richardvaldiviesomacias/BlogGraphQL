using System.ComponentModel;
using BlogGraphQL.Models.App;

namespace BlogGraphQL.ViewModels
{
    public class CommentViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public CommentModel CommentModel;
        public long Id => CommentModel.Id;
        public long PostId => CommentModel.PostId;
        public string Body => CommentModel.Body;
        public long UserId => CommentModel.UserId;
        public CommentViewModel(CommentModel commentModel)
        {
            CommentModel = commentModel;
            commentModel.PropertyChanged += (o, e) => PropertyChanged?.Invoke(this, e); 
        }

    }
}