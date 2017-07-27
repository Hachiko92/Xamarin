using SQLite.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFEmpleados
{
    class DataAccess : IDisposable
    {
        private SQLiteConnection connection;
        public DataAccess()
        {
            /* con config obtiene con que dispositivo está trabajando (Android, iOS...) */
            var config = DependencyService.Get<IConfig>();

            /* SQLite utiliza la extension .db3 */
            connection = new SQLiteConnection(config.Plataforma, Path.Combine(config.DirectorioDB, "Empleados.db3"));

            /* crear la tabla */
            connection.CreateTable<Empleado>();
        }

        public void InsertEmpleado(Empleado empleado)
        {
            connection.Insert(empleado);
        }

        public void UpdateEmpleado(Empleado empleado)
        {
            connection.Update(empleado);
        }

        public void DeleteEmpleado(Empleado empleado)
        {
            connection.Delete(empleado);
        }

        public Empleado GetEmpleado(int IDempleado)
        {
            return connection.Table<Empleado>()
                  .FirstOrDefault(c => c.IDempleado == IDempleado);
        }

        public List<Empleado> GetEmpleados()
        {
            var lista = connection.Table<Empleado>()
                       .Select(c => c)
                       .OrderBy(c => c.Nombre)
                       .ToList();

            return lista;
        }

        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
