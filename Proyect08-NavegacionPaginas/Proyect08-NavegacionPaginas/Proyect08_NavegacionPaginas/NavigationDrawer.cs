using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyect08_NavegacionPaginas
{
    /* MasterDetailPage tiene un su propio navegador */
    public class NavigationDrawer : MasterDetailPage
    {
        public NavigationDrawer()
        {
            Title = "Navigation Drawer Using MasterDetailsPage";
            string[] myPagesName = { "Home", "Second", "Third" };
            ListView listview = new ListView { ItemsSource = myPagesName };
            Master = new ContentPage
            {
                Title = "Options",
                Content = listview,
                Icon = "Hamburger.png"
            };

            listview.ItemTapped += (sender, e) =>
            {
                ContentPage goToPage;
                switch (e.Item.ToString())
                {
                    case "Home":
                        goToPage = new HomePage();
                        break;
                    case "Second":
                        goToPage = new SecondPage();
                        break;
                    case "Third":
                        goToPage = new ThirdPage();
                        break;
                    default:
                        goToPage = new FirstPage();
                        break;
                }
                Detail = new NavigationPage(goToPage);
                ((ListView)sender).SelectedItem = null;
                /* para deseactivar la opcion para definir un MasterDetail */
                IsPresented = false;
            };

            Detail = new NavigationPage(new HomePage());
                        
        }
    }
}