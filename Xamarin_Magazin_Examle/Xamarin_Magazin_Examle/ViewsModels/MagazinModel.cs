using System;
using System.Collections.Generic;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace Xamarin_Magazin_Examle.ViewsModels
{
    class MagazinModel : ContentPage
    {
       public MagazinModel()
       {
            StartAsync();
       }
        public Models.Shop Shop;
        async void StartAsync() { Shop = await GetShopAsync(); }
        public async Task<string> Get(string url) { return await Task.FromResult(new System.Net.WebClient().DownloadString(url)); }
        public async Task <Models.Shop> GetShopAsync()
        {
           string XMLdata = await Get("http://partner.market.yandex.ru/pages/help/YML.xml");
           var objShop = new Models.Shop();
           objShop.offers = new List<Models.Offer>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.LoadXml(XMLdata);
            
            XmlNodeList listOfers = xDoc.SelectNodes("/yml_catalog/shop/offers/offer");
            foreach (XmlNode offerItem in listOfers)
            {
                objShop.offers.Add(new Models.Offer() { id = offerItem.Attributes["id"].Value, json = JsonConvert.SerializeXmlNode(offerItem) });
            }
           
            return await Task.FromResult(objShop);
        }
    }
}
