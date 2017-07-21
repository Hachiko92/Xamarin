using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyect08_NavegacionPaginas
{
    public class DetailsPage : ContentPage
    {
        public DetailsPage(ListItem item)
        {
            Label tituloLabel = new Label
            {
                Text = item.Title,
                FontSize = 40
            };

            Label descripcionLabel = new Label
            {
                Text = item.Description,
                FontSize = 35
            };

            StackLayout stacklayout = new StackLayout()
            {
                Children =
                {
                    tituloLabel,
                    descripcionLabel
                }
            };

            Content = stacklayout;
        }
    }
}