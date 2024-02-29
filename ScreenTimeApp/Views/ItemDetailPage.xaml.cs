using ScreenTimeApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ScreenTimeApp.Views
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