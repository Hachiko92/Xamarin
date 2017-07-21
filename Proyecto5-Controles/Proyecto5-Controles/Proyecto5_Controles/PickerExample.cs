using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyecto5_Controles
{
    public class PickerExample : ContentPage
    {
        public PickerExample()
        {
            Label eventValue = new Label();
            Label pageValue = new Label();
            Picker picker = new Picker()
            {
                Title = "Lista de Elementos",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            /* creacción de la lista de elementos */
            var options = new List<String>
            {
                "First",
                "Second",
                "Third",
                "Fourth"
            };

            /* pasar la lista al Picker */
            foreach (string optionName in options)
            {
                picker.Items.Add(optionName);
            }

            /* Gestion de la opcion elejida */
            picker.SelectedIndexChanged += (sender, args) =>
            {
                pageValue.Text = picker.Items[picker.SelectedIndex];
            };

            Padding = new Thickness(10);
            Content = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    eventValue, pageValue, picker
                }
            };
        }
    }
}