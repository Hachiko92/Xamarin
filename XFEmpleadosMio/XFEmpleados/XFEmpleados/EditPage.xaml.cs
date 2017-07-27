using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFEmpleados
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditPage : ContentPage
    {
        private Empleado empleado;
        public EditPage(Empleado empleado)
        {
            InitializeComponent();
            this.empleado = empleado;

            actualizarBoton.Clicked += ActualizarBoton_Clicked;
        }

        private async void ActualizarBoton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nombreEntry.Text))
            {
                await DisplayAlert("Error", "Debe ingresar un nombre", "Aceptar");
                nombreEntry.Focus();
                return;
            }

            if (string.IsNullOrEmpty(apellidoEntry.Text))
            {
                await DisplayAlert("Error", "Debe ingresar los apellidos", "Aceptar");
                apellidoEntry.Focus();
                return;
            }

            if (string.IsNullOrEmpty(salarioEntry.Text))
            {
                await DisplayAlert("Error", "Debe ingresar un salario", "Aceptar");
                salarioEntry.Focus();
                return;
            }

            Empleado empleado = new Empleado
            {
                IDempleado = this.empleado.IDempleado,
                Activo = activoSwitch.IsToggled,
                Apellido = apellidoEntry.Text,
                Nombre = nombreEntry.Text,
                Salario = decimal.Parse(salarioEntry.Text),
                FechaContracto = fechaContractoDatePicker.Date
            };

            using (var datos = new DataAccess())
            {
                datos.UpdateEmpleado(empleado);
            }

            await DisplayAlert("Confimarción", "Empleado actualizado correctamente", "Aceptar");
            await Navigation.PushAsync(new HomePage());
        }
    }
}