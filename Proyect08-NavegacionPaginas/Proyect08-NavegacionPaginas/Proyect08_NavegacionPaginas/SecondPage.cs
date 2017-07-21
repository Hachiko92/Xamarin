using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyect08_NavegacionPaginas
{
    public class SecondPage : ContentPage
    {
        public SecondPage()
        {
            Label label = new Label
            {
                Text = "Segunda Pagina",
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