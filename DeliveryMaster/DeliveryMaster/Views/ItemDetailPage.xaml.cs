using System.ComponentModel;
using Xamarin.Forms;
using DeliveryMaster.ViewModels;

namespace DeliveryMaster.Views
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