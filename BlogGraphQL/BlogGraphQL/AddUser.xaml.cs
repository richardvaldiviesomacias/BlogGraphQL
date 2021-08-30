using System.Windows.Input;
using BlogGraphQL.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlogGraphQL
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddUser
    {
        public UserViewModel UserViewModel { get; set; }

        public AddUser(UserViewModel userViewModel)
        {
            InitializeComponent();
            BindingContext = UserViewModel = userViewModel;
        }

    }
}