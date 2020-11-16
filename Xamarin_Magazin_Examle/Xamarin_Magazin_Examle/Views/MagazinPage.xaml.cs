using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Magazin_Examle.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MagazinPage : ContentPage
    {
        ViewsModels.MagazinModel model;

        public MagazinPage()
        {
            InitializeComponent();
            BindingContext = model = new ViewsModels.MagazinModel();
            ShopListView.ItemsSource = model.Shop.offers;
        }
        async void ToDetalsPage_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;
            Models.Offer item = (Models.Offer)e.SelectedItem;
            ((ListView)sender).SelectedItem = null;

            await Navigation.PushModalAsync(new Views.OfferPage(new ViewsModels.OfferModel(item)));
        }
    }
}
