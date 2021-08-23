using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogGraphQL.Models.App;
using BlogGraphQL.Services;
using BlogGraphQL.ViewModels;
using Xamarin.Forms;

namespace BlogGraphQL
{
    public partial class MainPage : ContentPage
    {
        public MainPage(BlogViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}