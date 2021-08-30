using System;
using BlogGraphQL.Models.App;
using BlogGraphQL.ViewModels;
using Xamarin.Forms;

namespace BlogGraphQL
{
    public partial class MainPage : ContentPage
    {
        private readonly BlogViewModel blogViewModel;

        public MainPage(BlogViewModel viewModel)
        {
            InitializeComponent();
            blogViewModel = viewModel;
            BindingContext = viewModel;
        }

        protected override async void OnAppearing()
        {
            await blogViewModel.BlogModel.InitializeAsync();
            blogViewModel.InitializeUsers();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddUser(new UserViewModel(new UserModel())));
        }
    }
}