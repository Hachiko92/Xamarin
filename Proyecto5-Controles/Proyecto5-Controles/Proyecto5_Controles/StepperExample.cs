using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyecto5_Controles
{
    public class StepperExample : ContentPage
    {
        public StepperExample()
        {
            Label eventValue = new Label();
            Label pageValue = new Label();

            Stepper stepper = new Stepper
            {
                Minimum = 0,
                Maximum = 10,
                Increment = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            stepper.ValueChanged += (sender, e) =>
            {
                eventValue.Text = e.NewValue.ToString();
                pageValue.Text = stepper.Value.ToString();
            };

            Padding = new Thickness(10);
            Content = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    eventValue, pageValue, stepper
                }
            };
        }
    }
}