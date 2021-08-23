using System.ComponentModel;

namespace BlogGraphQL.Models.App
{
    public class UserModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public long Id { get; set; }
        public string Name { get; set; }
    }
}