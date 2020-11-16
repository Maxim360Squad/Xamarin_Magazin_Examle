using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Magazin_Examle
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.MagazinPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
