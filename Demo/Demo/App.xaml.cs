using System;
using Demo.MasterDetail;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();


            MainPage = new MasterDetailPageMain();
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
