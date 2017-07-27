using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFEmpleados
{
    public class EmpleadoCell:ViewCell
    {
        public EmpleadoCell()
        {
            var IDEmpleadoLabel = new Label
            {
                TextColor= Color.Black,
                Font=Font.BoldSystemFontOfSize(NamedSize.Medium),
                HorizontalOptions = LayoutOptions.Start
            };
            IDEmpleadoLabel.SetBinding(Label.TextProperty, new Binding("IDEmpleado"));

            var NombreLabel = new Label
            {
                TextColor = Color.Black,
                Font = Font.BoldSystemFontOfSize(NamedSize.Medium),
                HorizontalOptions = LayoutOptions.Fill
            };
            NombreLabel.SetBinding(Label.TextProperty, new Binding("Nombre"));

            var ApellidoLabel = new Label
            {
                TextColor = Color.Black,
                Font = Font.BoldSystemFontOfSize(NamedSize.Medium),
                HorizontalOptions = LayoutOptions.Start
            };
            ApellidoLabel.SetBinding(Label.TextProperty, new Binding("Apellido"));

            var SalarioLabel = new Label
            {
                TextColor = Color.Black,
                Font = Font.BoldSystemFontOfSize(NamedSize.Medium),
                HorizontalOptions = LayoutOptions.Start
            };
            SalarioLabel.SetBinding(Label.TextProperty, new Binding("Salario"));

            var FechaContratoLabel = new Label
            {
                TextColor = Color.Black,
                Font = Font.BoldSystemFontOfSize(NamedSize.Medium),
                HorizontalOptions = LayoutOptions.Start
            };
            FechaContratoLabel.SetBinding(Label.TextProperty, new Binding("FechaContrato"));

            var ActivoSwitch = new Switch
            {
                HorizontalOptions=LayoutOptions.End
            };
            ActivoSwitch.SetBinding(Switch.IsToggledProperty, new Binding("Activo"));

            View = new StackLayout
            {
                Children =
                {
                    IDEmpleadoLabel,NombreLabel,ApellidoLabel,
                    SalarioLabel,FechaContratoLabel,ActivoSwitch
                },
                Orientation = StackOrientation.Horizontal
            };
        }
    }
}
