using System;
using BlogGraphQL.Models.App;
using BlogGraphQL.Services;
using BlogGraphQL.Services.Mapping;
using BlogGraphQL.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace BlogGraphQL
{
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; set; }
        public App()
        {
            InitializeComponent();
            ServiceProvider = Startup.InitializeServices();
            var userService = ServiceProvider.GetRequiredService<IUserService>();
            var viewModel = new BlogViewModel(new BlogModel(userService));
            MainPage = new NavigationPage(new MainPage(viewModel));
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