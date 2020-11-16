using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin_Magazin_Examle.ViewsModels
{
    public class OfferModel
    {
        public Models.Offer Item { get; set; }
        public OfferModel(Models.Offer offer)
        {
            Item = offer;
        }
    }
}
