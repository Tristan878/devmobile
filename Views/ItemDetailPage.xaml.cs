using System.ComponentModel;
using Xamarin.Forms;
using projectDevMobile.ViewModels;

namespace projectDevMobile.Views
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