using System.ComponentModel;
using BlogGraphQL.Models.App;

namespace BlogGraphQL.ViewModels
{
    public class UserViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public readonly UserModel UserModel;
        public long Id => UserModel.Id;
        public string Name => UserModel.Name;
        public UserViewModel(UserModel userModel)
        {
            UserModel = userModel;
            userModel.PropertyChanged += (o, e) => PropertyChanged?.Invoke(this, e); 
        }

    }
}