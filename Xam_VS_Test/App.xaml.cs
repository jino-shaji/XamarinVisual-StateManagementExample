using System;
using Xam_VS_Test.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xam_VS_Test
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
