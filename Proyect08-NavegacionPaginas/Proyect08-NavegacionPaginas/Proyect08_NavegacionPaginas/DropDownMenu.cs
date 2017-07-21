using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyect08_NavegacionPaginas
{
    public class DropDownMenu : ContentPage
    {
        public DropDownMenu()
        {
            /* para trabajar con los elementos de la barra de navegación */
            ToolbarItems.Clear();

            ToolbarItems.Add(new ToolbarItem
            {
                Text = "Home",
                /* .Primary trabajaría directamente con los 3 puntitos,
                 * .Secondary permite de abrir un menu desde los puntitos */
                Order = ToolbarItemOrder.Secondary,
                Command = new Command(() => Navigation.PushAsync(new FirstPage()))
            });

            ToolbarItems.Add(new ToolbarItem
            {
                Text = "Second",
                Order = ToolbarItemOrder.Secondary,
                Command = new Command(() => Navigation.PushAsync(new SecondPage()))
            });
        }
    }
}