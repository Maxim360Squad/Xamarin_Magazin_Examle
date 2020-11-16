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
        ViewsModels.OfferModel model;
        public OfferPage(ViewsModels.OfferModel offerModel)
        {
            InitializeComponent();
            BindingContext = model = offerModel;
        }

        private async void BackButton_Click(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}