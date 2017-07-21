using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyecto5_Controles
{
    public class SwitchExamplecs : ContentPage
    {
        public SwitchExamplecs()
        {
            Label eventValue = new Label();
            Label pageValue = new Label();

            Switch switcher = new Switch()
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            switcher.Toggled += (sender, e) =>
            {
                eventValue.Text = e.Value.ToString();
                pageValue.Text = switcher.IsToggled.ToString();
            };

            Padding = new Thickness(10);
            Content = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    eventValue, pageValue, switcher
                }
            };
        }
    }
}