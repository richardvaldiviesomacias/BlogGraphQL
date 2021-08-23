using System.ComponentModel;

namespace BlogGraphQL.Models.App
{
    public class CommentModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public long Id { get; set; }
        public long PostId { get; set; }
        public string Body { get; set; }
        public long UserId { get; set; }
    }
}