using Spectrum.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Spectrum.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel _viewModel;

        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = _viewModel =  new ItemDetailViewModel();
        }
    }
}