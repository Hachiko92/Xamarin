using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyecto5_Controles
{
    public class TimePickerExample : ContentPage
    {
        public TimePickerExample()
        {
            Label eventValue = new Label();
            Label pageValue = new Label();

            TimePicker timePicker = new TimePicker()
            {
                Format = "T",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            timePicker.PropertyChanged += (s, e) =>
            {
                if(e.PropertyName == TimePicker.TimeProperty.PropertyName)
                {
                    pageValue.Text = timePicker.Time.ToString();
                }
            };

            Padding = new Thickness(10);
            Content = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    eventValue, pageValue, timePicker
                }
            };
        }
    }
}