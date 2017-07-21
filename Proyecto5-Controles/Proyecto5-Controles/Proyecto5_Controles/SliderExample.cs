using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyecto5_Controles
{
    public class SliderExample : ContentPage
    {
        public SliderExample()
        {
            Label eventValue = new Label();
            Label pageValue = new Label();

            Slider slider = new Slider
            {
                Minimum = 0,
                Maximum = 100,
                Value = 20,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                WidthRequest = 300
            };

            slider.ValueChanged += (sender, e) =>
            {
                eventValue.Text = e.NewValue.ToString();
                pageValue.Text = String.Format("Slider: {0:F1}");
            };

            Padding = new Thickness(10);
            Content = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    eventValue, pageValue, slider
                }
            };
        }
    }
}