using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Magazin_Examle.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OfferPage : ContentPage
    {
        public Models.Offer Item;
        public OfferPage()
        {
            InitializeComponent();
            Item = new Models.Offer { id = "ERROR", json = "ERROR" };
            BindingContext = this;
        }
        public OfferPage(Models.Offer offer)
        {
            InitializeComponent();
            Item = offer;
            Test();
        }

        async void Test()
        {
          await  DisplayAlert("Item Tapped", Item.id, "OK");

        }
        private async void BackButton_Click(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

    }
}