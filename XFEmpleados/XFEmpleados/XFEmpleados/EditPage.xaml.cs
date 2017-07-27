using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFEmpleados
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditPage : ContentPage
    {
        private Empleado empleado;
        public EditPage(Empleado empleado)
        {
            InitializeComponent();
            this.empleado = empleado;

            
            ActualizarButton.Clicked += ActualizarButton_Clicked;
            BorrarButton.Clicked += BorrarButton_Clicked;

            NombreEntry.Text = empleado.Nombre;
            ApellidoEntry.Text = empleado.Apellido;
            SalarioEntry.Text = empleado.Salario.ToString();
            fechaContratoDatePicker.Date = empleado.FechaContrato;
            activoSwitch.IsToggled = empleado.Activo;


        }

        

        public async void BorrarButton_Clicked(object sender, EventArgs e)
        {
            var rta = await DisplayAlert("Confirmación", "¿Desea borrar el empleado?", "Si", "No");

            if (rta)
            {
                using (var datos = new DataAccess())
                {
                    datos.DeleteEmpleado(empleado);
                }
                await DisplayAlert("Confirmación", "Empleado borrado correctamente", "Aceptar");
                await Navigation.PushAsync(new HomePage());
            }
        }

        public async void ActualizarButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NombreEntry.Text))
            {
                await DisplayAlert("Error", "Debe ingresar nombre", "Aceptar");
                NombreEntry.Focus();
                return;
            }
            if (string.IsNullOrEmpty(ApellidoEntry.Text))
            {
                await DisplayAlert("Error", "Debe ingresar apellido", "Aceptar");
                ApellidoEntry.Focus();
                return;
            }
            if (string.IsNullOrEmpty(SalarioEntry.Text))
            {
                await DisplayAlert("Error", "Debe ingresar salario", "Aceptar");
                SalarioEntry.Focus();
                return;
            }
            Empleado empleado = new Empleado
            {
                IDEmpleado = this.empleado.IDEmpleado,
                Activo = activoSwitch.IsToggled,
                Apellido = ApellidoEntry.Text,
                Nombre=NombreEntry.Text,
                FechaContrato=fechaContratoDatePicker.Date,
                Salario=decimal.Parse(SalarioEntry.Text)

            };
            using (var datos = new DataAccess())
            {
                datos.UpdatetEmpleado(empleado);
            }
            await DisplayAlert("Confirmación", "Empleado actualizado correctamente", "Aceptar");
            await Navigation.PushAsync(new HomePage());

        }

    }
}
