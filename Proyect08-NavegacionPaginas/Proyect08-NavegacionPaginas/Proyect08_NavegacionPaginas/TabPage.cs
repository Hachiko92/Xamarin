using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyect08_NavegacionPaginas
{
    public class TabPage : TabbedPage
    {
        public TabPage()
        {
            Title = "Tabbed Page";
            Children.Add(new HomePage()
            {
                Title = "Home Page",
                Icon = "start.png"
            });
            Children.Add(new SecondPage());
            Children.Add(new FirstPage());
            Children.Add(new ThirdPage());
        }
    }
}