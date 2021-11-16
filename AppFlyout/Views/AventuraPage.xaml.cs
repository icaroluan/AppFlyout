using AppFlyout.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppFlyout.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class AventuraPage : ContentPage
    {
        AventuraItemsViewModel _viewModel;

        public AventuraPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new AventuraItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}