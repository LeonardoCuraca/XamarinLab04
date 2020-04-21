using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab4
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new Page1());
            //MainPage = new TabbedPage();
            //MainPage = new CarouselPage1();
            MainPage = new NavigationPage(new Page3());
            //MainPage = new MainPage();
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
