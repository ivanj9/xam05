using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xam05.Services;
using xam05.Views;

namespace xam05
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
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
