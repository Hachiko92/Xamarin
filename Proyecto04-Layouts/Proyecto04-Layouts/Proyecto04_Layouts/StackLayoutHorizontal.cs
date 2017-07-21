using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyecto04_Layouts
{
    public class StackLayoutHorizontal : ContentPage
    {
        public StackLayoutHorizontal()
        {
            StackLayout stackLayout = new StackLayout
            {
                /* Spacing por default es igual a 0 */
                Spacing = 1,
                /* Aunque se proyecta uno StackLayout horizontal es justo definir que tiene
                 * que hacer el dispositivo cuando se baja la linea */
                /* FillAndExpand hace si que cada elemento ocupe una linea y está de default*/
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    new Label
                    {
                        Text = "Start is flush left",
                        HorizontalOptions = LayoutOptions.Start
                    },
                    new Label
                    {
                        Text = "Center",
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new Label
                    {
                        Text = "Start is flush right",
                        HorizontalOptions = LayoutOptions.End
                    }
                }
            };

            StackLayout stackLayoutHorizontal = new StackLayout
            {
                Spacing = 1,
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    new Label
                    {
                        Text = "Start <-------"
                    },
                    new Label
                    {
                        Text = "--- Center ---",
                        HorizontalOptions = LayoutOptions.CenterAndExpand
                    },
                    new Label
                    {
                        Text = "---------> End"
                    }
                }
            };

            Padding = new Thickness(10);
            Content = stackLayoutHorizontal;
        }
    }
}