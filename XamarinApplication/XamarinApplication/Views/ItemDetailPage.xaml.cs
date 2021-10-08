using System.ComponentModel;
using Xamarin.Forms;
using XamarinApplication.ViewModels;

namespace XamarinApplication.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}