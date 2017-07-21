using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyect08_NavegacionPaginas
{
    public class TabPageDataBound : TabbedPage
    {
        public TabPageDataBound()
        {
            Title = "Data Bound TabbedPage";
            ItemsSource = new TabItem[] 
            {
                new TabItem("First", 1),
                new TabItem("Second", 2),
                new TabItem("Third", 3),
                new TabItem("Fourth", 4),
                new TabItem("Fifth", 5),
                new TabItem("Sixth", 6)
            };

            ItemTemplate = new DataTemplate(() =>
            {
                return new NumberPage();
            });
        }
    }
}