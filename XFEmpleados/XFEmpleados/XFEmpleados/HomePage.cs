using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFEmpleados
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            Label labelEmpleados = new Label
            {
                Text = "Empleados",
                FontSize = 24,
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.Black
            };
            Entry nombreEntry = new Entry
            {
                Placeholder = "Nombre",
                TextColor = Color.Black
            };
            Entry apellidoEntry = new Entry
            {
                Placeholder = "Apellido",
                TextColor = Color.Black
            };
            Entry salarioEntry = new Entry
            {
                Placeholder = "Salario",
                TextColor = Color.White,
                Keyboard = Keyboard.Numeric
            };
            DatePicker fechaContratoDatePicker = new DatePicker { };
            Label labelActivo = new Label
            {
                Text = "Activo",
                FontSize = 18,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.EndAndExpand
            };
            Switch activoSwitch = new Switch
            {
                //VerticalOptions = LayoutOptions.FillAndExpand,
                IsToggled = true,
                HorizontalOptions = LayoutOptions.End
            };
            Button agregarBoton = new Button
            {
                Text = "Agregar",
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Color.Yellow,
                TextColor = Color.Black
            };
            ListView listaListView = new ListView { };
            
            StackLayout stackLayout = new StackLayout
            {
                Children =
                {
                    labelEmpleados,
                    nombreEntry,
                    apellidoEntry,
                    salarioEntry,
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            fechaContratoDatePicker,
                            labelActivo,
                            activoSwitch
                        }
                    },
                    agregarBoton,
                    listaListView
                }
            };
            
            listaListView.ItemSelected += ListaListView_ItemSelected;

        agregarBoton.Clicked += async (sender, e) =>
            {
                if (string.IsNullOrEmpty(nombreEntry.Text))
                {
                    await DisplayAlert("Error", "debe Ingresar nombre", "Aceptar");
                    nombreEntry.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(apellidoEntry.Text))
                {
                    await DisplayAlert("Error", "debe Ingresar apelllidos", "Aceptar");
                    apellidoEntry.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(salarioEntry.Text))
                {
                    await DisplayAlert("Error", "debe Ingresar salario", "Aceptar");
                    salarioEntry.Focus();
                    return;
                }
                Empleado empleado = new Empleado()
                {
                    Nombre = nombreEntry.Text,
                    Apellido = apellidoEntry.Text,
                    Activo = activoSwitch.IsToggled,
                    Salario = decimal.Parse(salarioEntry.Text),
                    FechaContrato = fechaContratoDatePicker.Date
                };
                using (var datos = new DataAccess())
                {
                    datos.InsertEmpleado(empleado);
                    listaListView.ItemsSource = datos.GetEmpleados();

                }
                nombreEntry.Text = string.Empty;
                apellidoEntry.Text = string.Empty;
                salarioEntry.Text = string.Empty;
                fechaContratoDatePicker.Date = DateTime.Now;
                await DisplayAlert("Mensaje", "Empleado creado correctamente", "Aceptar");
            };
            listaListView.ItemTemplate = new DataTemplate(typeof(EmpleadoCell));
            //Rellenamos la lista de empleados
            using (var datos=new DataAccess())
            {
                listaListView.ItemsSource = datos.GetEmpleados();
            }
            //Lo metemos en una vista scrolleable
            this.Content = new ScrollView { Content = stackLayout };
        }

        private void ListaListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new EditPage((Empleado)e.SelectedItem));
        }
    }
}
