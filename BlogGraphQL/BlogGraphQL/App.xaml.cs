using System;
using BlogGraphQL.Models.App;
using BlogGraphQL.Services;
using BlogGraphQL.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace BlogGraphQL
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var viewModel = new BlogViewModel(new BlogModel(new UserService(new UserMapping())));
            MainPage = new MainPage(viewModel);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}