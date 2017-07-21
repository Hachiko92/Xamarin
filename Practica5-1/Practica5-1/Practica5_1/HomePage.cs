using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Practica5_1
{
    public class HomePage : ContentPage
    {
        public class Empleado
        {
            public string Nombre { get; set; }
            public string Cargo { get; set; }
        }

        public class Grupo : List<Empleado>
        {
            public string Llave { get; private set; }
            public Grupo (string llave, List<Empleado> empleados)
            {
                Llave = llave;
                foreach (var empleado in empleados)
                    Add(empleado);
            }
        }
        public HomePage()
        {
            List<Grupo> listaPersonal = new List<Grupo>()
            {
                new Grupo ("Contabilidad", new List<Empleado> {
                    new Empleado {Nombre = "Juan Ramirez", Cargo = "Jefe Contabilidad" },
                    new Empleado {Nombre = "Inés Jiménez", Cargo = "Jefe Unidad Ventas" }
                }),
                new Grupo ("Ventas", new List<Empleado> {
                    new Empleado {Nombre = "Jesús Móran", Cargo = "Jefe Ventas" },
                    new Empleado {Nombre = "Evaristo González", Cargo = "Administrativo Ventas" }
                })
            };

            ListView listview = new ListView()
            {
                IsGroupingEnabled = true,
                GroupDisplayBinding = new Binding("Llave"),
                GroupHeaderTemplate = new DataTemplate(typeof(HeaderCell)),
                HasUnevenRows = true,
                ItemTemplate = new DataTemplate(typeof(TextCell))
                {
                    Bindings =
                    {
                        { TextCell.TextProperty, new Binding("Nombre") },
                        { TextCell.DetailProperty, new Binding("Cargo") }
                    }
                }
            };

            listview.ItemsSource = listaPersonal;

            listview.ItemTapped += async (sender, e) =>
            {
                Empleado empleado = (Empleado)e.Item;
                await DisplayAlert("Tapped", empleado.Nombre.ToString() + " con cargo: " + empleado.Cargo.ToString() + " ha sido seleccionado.", "OK");
                ((ListView)sender).SelectedItem = null;
            };

            Padding = new Thickness(0, 20, 0, 0);
            Content = new StackLayout()
            {
                Children =
                {
                    new Label
                    {
                        Text = "Lista de Personal",
                        BackgroundColor = Color.Goldenrod,
                        TextColor = Color.White,
                        HorizontalOptions = LayoutOptions.Center
                    },
                    listview
                }
            };
        }

        public class HeaderCell : ViewCell
        {
            public HeaderCell()
            {
                Height = 40;
                Label titulo = new Label
                {
                    TextColor = Color.Black,
                    FontSize = 16,
                    VerticalOptions = LayoutOptions.Center,
                };
                titulo.SetBinding(Label.TextProperty, "Llave");

                View = new StackLayout
                {
                    HeightRequest = 40,
                    BackgroundColor = Color.White,
                    Padding = 5,
                    Children =
                    {
                        titulo
                    }
                };
            }
        }
    }
}