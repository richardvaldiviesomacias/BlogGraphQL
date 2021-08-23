using System.ComponentModel;

namespace BlogGraphQL.Models.App
{
    public class PostModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public long Id { get; set; }
        public string Title { get; set; }
        public long Views { get; set; }
        public long UserId { get; set; }
    }
}