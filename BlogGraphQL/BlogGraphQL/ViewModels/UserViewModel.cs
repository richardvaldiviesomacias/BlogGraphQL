using System.ComponentModel;
using BlogGraphQL.Models.App;

namespace BlogGraphQL.ViewModels
{
    public class UserViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly UserModel userModel;
        public long Id => userModel.Id;
        public string Name => userModel.Name;

        public UserViewModel(UserModel userModel)
        {
            this.userModel = userModel;
            userModel.PropertyChanged += (_, e) => PropertyChanged?.Invoke(this, e);
        }
    }
}