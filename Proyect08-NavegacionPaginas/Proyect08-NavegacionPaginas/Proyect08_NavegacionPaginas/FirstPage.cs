using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyect08_NavegacionPaginas
{
    public class FirstPage : ContentPage
    {
        public FirstPage()
        {
            Label label = new Label
            {
                Text = "Primera Pagina",
                FontSize = 40
            };

            StackLayout stacklayout = new StackLayout()
            {
                Children =
                {
                    label
                }
            };

            Content = stacklayout;
        }
    }
}