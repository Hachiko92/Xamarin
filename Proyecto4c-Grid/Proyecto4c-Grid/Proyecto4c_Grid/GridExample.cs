using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyecto4c_Grid
{
    public class GridExample : ContentPage
    {
        public GridExample()
        {
            Grid grid = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions =
                {
                    /* es mejor utilizar el auto */
                    new RowDefinition{Height = GridLength.Auto},
                    /* minimo 200, si llega algo más grande lo pinta también */
                    new RowDefinition {Height = new GridLength(200, GridUnitType.Auto)},
                    new RowDefinition {Height = new GridLength(200, GridUnitType.Auto)},
                    new RowDefinition{Height = GridLength.Auto},
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition {Width = GridLength.Auto},
                    /* la columna se pone en su primera (1) posicción */
                    new ColumnDefinition {Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition {Width = GridLength.Auto}
                }
            };

            /* 0-0 */
            grid.Children.Add(new Label
            {
                Text = "Yo soy el 0.0",
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            }, 0, 0);

            /* 0-3 */
            grid.Children.Add(new Label
            {
                Text = "Yo soy el 0.3",
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            }, 0, 3);

            /* 1-3 */
            grid.Children.Add(new Label
            {
                Text = "Yo soy el 1.3",
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Black,
                BackgroundColor = Color.Lime
            }, 1, 3, 1, 2);

            

            Padding = new Thickness(10, 20, 10, 5);
            Content = grid;

        }
    }
}