using System.ComponentModel;
using BlogGraphQL.Models.App;

namespace BlogGraphQL.ViewModels
{
    public class CommentViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly CommentModel commentModel;
        public long Id => commentModel.Id;
        public long PostId => commentModel.PostId;
        public string Body => commentModel.Body;
        public long UserId => commentModel.UserId;

        public CommentViewModel(CommentModel commentModel)
        {
            this.commentModel = commentModel;
            commentModel.PropertyChanged += (_, e) => PropertyChanged?.Invoke(this, e);
        }
    }
}