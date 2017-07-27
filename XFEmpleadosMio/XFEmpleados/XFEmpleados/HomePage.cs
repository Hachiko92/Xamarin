using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XFEmpleados
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            /* InterFac Usuario */
            Label labelEmpleados = new Label
            {
                Text = "Empleados",
                FontSize = 24,
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.Black
            };

            Entry nombreEntry = new Entry()
            {
                Placeholder = "Nombre",
                TextColor = Color.Black
            };

            Entry apellidoEntry = new Entry()
            {
                Placeholder = "Apellido",
                TextColor = Color.Black
            };

            Entry salarioEntry = new Entry()
            {
                Placeholder = "Salario",
                TextColor = Color.Black,
                Keyboard = Keyboard.Numeric
            };

            DatePicker fechaContractoDatePicker = new DatePicker
            {
                MaximumDate = DateTime.Today
            };

            Label labelActivo = new Label
            {
                Text = "Activo",
                FontSize = 18,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.EndAndExpand
            };
            Switch activoSwitch = new Switch
            {
                IsToggled = true,
                HorizontalOptions = LayoutOptions.End
            };

            Button agregarBoton = new Button
            {
                Text = "AGREGAR",
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Color.Yellow,
                TextColor = Color.Black
            };

            ListView listaListView = new ListView() { };

            StackLayout stacklayout = new StackLayout()
            {
                Padding = new Thickness(20, 0, 20, 0),
                Children =
                {
                    labelEmpleados,
                    nombreEntry,
                    apellidoEntry,
                    salarioEntry,
                    new StackLayout()
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            fechaContractoDatePicker,
                            labelActivo,
                            activoSwitch
                        }
                    },
                    agregarBoton,
                    listaListView
                }
            };

            /* FIN Interfaz */

            /* Gestión Bóton */
            agregarBoton.Clicked += async (sender, e) =>
            {
                if (string.IsNullOrEmpty(nombreEntry.Text))
                {
                    await DisplayAlert("Error", "Debes ingresar un nombre", "Aceptar");
                    nombreEntry.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(apellidoEntry.Text))
                {
                    await DisplayAlert("Error", "Debes ingresar los Apellidos", "Aceptar");
                    apellidoEntry.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(salarioEntry.Text))
                {
                    await DisplayAlert("Error", "Debes ingresar un Salario", "Aceptar");
                    apellidoEntry.Focus();
                    return;
                }

                Empleado empleado = new Empleado()
                {
                    Nombre = nombreEntry.Text,
                    Apellido = apellidoEntry.Text,
                    Activo = activoSwitch.IsToggled,
                    Salario = Decimal.Parse(salarioEntry.Text),
                    FechaContracto = fechaContractoDatePicker.Date
                };

                /* pasar la conexion */
                using(var datos = new DataAccess())
                {
                    datos.InsertEmpleado(empleado);
                    listaListView.ItemsSource = datos.GetEmpleados();
                }

                nombreEntry.Text = string.Empty;
                apellidoEntry.Text = string.Empty;
                salarioEntry.Text = string.Empty;
                fechaContractoDatePicker.Date = DateTime.Now;
                activoSwitch.IsToggled = true;
                await DisplayAlert("Mensaje", "Empleado creado correctamente", "Aceptar");
            };

            listaListView.ItemTemplate = new DataTemplate(typeof(EmpleadoCell));

            using(var datos = new DataAccess())
            {
                listaListView.ItemsSource = datos.GetEmpleados();

            }

            /* no tapped porque se utiliza solo per mensages,
             * selected cuando hay que hacer una gestión */
            listaListView.ItemSelected += ListaListView_ItemSelected;

            Content = new ScrollView()
            {
                Padding = new Thickness(20, 0, 20, 0),
                Content = stacklayout
            };
        }

        private void ListaListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new EditPage((Empleado)e.SelectedItem));
        }
    }
}