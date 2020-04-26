using HelloWorld;
using HelloXamarinWorld.List;
using HelloXamarinWorld.Navigation;
using HelloXamarinWorld.Navigation.MasterDetails1;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloXamarinWorld
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ContactsPage()) { BarBackgroundColor = Color.DeepPink, BarTextColor = Color.White };
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
