using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBuku.TMobileFromWeb.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BukuPage : ContentPage
    {
        ViewModels.BukuViewModel _viewModel;
        public BukuPage()
        {
            InitializeComponent();
            this.BindingContext = _viewModel = new ViewModels.BukuViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}