using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Proyect08_NavegacionPaginas
{
    public class DrillDownTableView : ContentPage
    {
        public DrillDownTableView()
        {
            /* siempre cuando se hace una navegacion se utiliza el async */
            Command<Type> navigateCommand = new Command<Type>(async (Type pageType) =>
            {
                Page page = (Page)Activator.CreateInstance(pageType);
                await Navigation.PushAsync(page);
            });
            Title = "Drilldown Using TableView";
            Content = new TableView()
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                {
                    new TableSection("Hindi")
                    {
                        new TextCell
                        {
                            Text = "Prahtma",
                            Command = navigateCommand,
                            CommandParameter = typeof(FirstPage)
                        },
                        new TextCell
                        {
                            Text = "Düsara",
                            Command = navigateCommand,
                            CommandParameter = typeof(SecondPage)
                        },
                        new TextCell
                        {
                            Text = "Tisara",
                            Command = navigateCommand,
                            CommandParameter = typeof(ThirdPage)
                        },
                    },
                    new TableSection("Castellano")
                    {
                        new TextCell
                        {
                            Text = "Primero",
                            Command = navigateCommand,
                            CommandParameter = typeof(FirstPage)
                        },
                        new TextCell
                        {
                            Text = "Segundo",
                            Command = navigateCommand,
                            CommandParameter = typeof(SecondPage)
                        },
                        new TextCell
                        {
                            Text = "Tercero",
                            Command = navigateCommand,
                            CommandParameter = typeof(ThirdPage)
                        },
                    },
                    new TableSection("Inglés")
                    {
                        new TextCell
                        {
                            Text = "Firsth",
                            Command = navigateCommand,
                            CommandParameter = typeof(FirstPage)
                        },
                        new TextCell
                        {
                            Text = "Second",
                            Command = navigateCommand,
                            CommandParameter = typeof(SecondPage)
                        },
                        new TextCell
                        {
                            Text = "Third",
                            Command = navigateCommand,
                            CommandParameter = typeof(ThirdPage)
                        },
                    }
                }
            };
        }
    }
}