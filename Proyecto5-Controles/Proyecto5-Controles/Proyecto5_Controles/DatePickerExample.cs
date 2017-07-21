using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyecto5_Controles
{
    public class DatePickerExample : ContentPage
    {
        public DatePickerExample()
        {
            Label eventValue = new Label();
            Label pageValue = new Label();
            
            DatePicker datePicker = new DatePicker()
            {
                Format = "d",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            datePicker.DateSelected += (object sender, DateChangedEventArgs e) =>
            {
                eventValue.Text = e.NewDate.ToString();
                pageValue.Text = datePicker.Date.ToString();
            };

            Padding = new Thickness(10);
            Content = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    eventValue, pageValue, datePicker
                }
            };
        }
    }
}