using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFEmpleados
{
    public class EmpleadoCell : ViewCell
    {
        public EmpleadoCell()
        {
            var idEmpleadoLabel = new Label
            {
                TextColor = Color.Black,
                Font = Font.BoldSystemFontOfSize(NamedSize.Medium),
                HorizontalOptions = LayoutOptions.Start
            };
            idEmpleadoLabel.SetBinding(Label.TextProperty, new Binding("IDempleado"));

            var nombreLabel = new Label
            {
                TextColor = Color.Black,
                Font = Font.BoldSystemFontOfSize(NamedSize.Medium),
                HorizontalOptions = LayoutOptions.Start
            };
            nombreLabel.SetBinding(Label.TextProperty, new Binding("Nombre"));

            var ApellidoLabel = new Label
            {
                TextColor = Color.Black,
                Font = Font.BoldSystemFontOfSize(NamedSize.Medium),
                HorizontalOptions = LayoutOptions.Start
            };
            ApellidoLabel.SetBinding(Label.TextProperty, new Binding("Apellido"));

            var salarioLabel = new Label
            {
                TextColor = Color.Black,
                Font = Font.BoldSystemFontOfSize(NamedSize.Medium),
                HorizontalOptions = LayoutOptions.Start
            };
            salarioLabel.SetBinding(Label.TextProperty, new Binding("Salario"));

            var fechaContractoLabel = new Label
            {
                TextColor = Color.Black,
                Font = Font.BoldSystemFontOfSize(NamedSize.Medium),
                HorizontalOptions = LayoutOptions.Start
            };
            fechaContractoLabel.SetBinding(Label.TextProperty, new Binding("FechaContracto"));

            var activoSwitchLabel = new Label
            {
                TextColor = Color.Black,
                Font = Font.BoldSystemFontOfSize(NamedSize.Medium),
                HorizontalOptions = LayoutOptions.Start
            };
            activoSwitchLabel.SetBinding(Label.TextProperty, new Binding("Activo"));

            View = new StackLayout
            {
                Children =
                {
                    idEmpleadoLabel, nombreLabel, ApellidoLabel,
                    salarioLabel, fechaContractoLabel, activoSwitchLabel
                },
                Orientation = StackOrientation.Horizontal
            };
        }
    }
}
