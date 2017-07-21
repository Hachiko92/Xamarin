using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyect08_NavegacionPaginas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            /* necesita un patron de navegación */
            //MainPage = new NavigationPage(new HomePage());
            //MainPage = new NavigationPage(new DropDownMenu());
            //MainPage = new NavigationPage(new DrillDownListViewByItem());
            //MainPage = new NavigationPage(new DrillDownListViewByPage());
            MainPage = new NavigationPage(new DrillDownTableView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
