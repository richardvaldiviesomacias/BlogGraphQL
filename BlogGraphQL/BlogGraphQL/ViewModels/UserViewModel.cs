using System.ComponentModel;
using System.Windows.Input;
using BlogGraphQL.Models.App;
using Xamarin.Forms;

namespace BlogGraphQL.ViewModels
{
    public class UserViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand SaveCommand { get; set; }
        private readonly UserModel userModel;
        public long Id => userModel.Id;

        public string Name
        {
            get => userModel.Name;
            set => userModel.Name = value;
        }

        public UserViewModel(UserModel userModel)
        {
            this.userModel = userModel;
            SaveCommand = new Command(Save);
            userModel.PropertyChanged += (_, e) => PropertyChanged?.Invoke(this, e);
        }

        private void Save()
        {
            
        }
    }
}