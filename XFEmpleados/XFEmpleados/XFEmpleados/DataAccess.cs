using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
using Xamarin.Forms;
using System.IO;

namespace XFEmpleados
{
    class DataAccess : IDisposable
    {
        private SQLiteConnection connection;//creamos el objeto conexion

        //creamos un constructor
        public DataAccess()
        {
            //obtengo la configuración de la plataforma de la que venga
            var config = DependencyService.Get<IConfig>();
            //establezco la conexión
            //y combino el direcotorio de la base de datos con el nombre
            //que le doy a la base de datos con extensión db3 que es el estandar
            //que usa Xamarin
            connection = new SQLiteConnection(config.Plataforma,
                Path.Combine(config.DirectorioDB, "Empleados.db3"));
            //creo la tabla
            connection.CreateTable<Empleado>();
        }
        public void InsertEmpleado(Empleado empleado)
        {
            //Método público para insertar un empleado
            connection.Insert(empleado);
        }
        public void UpdatetEmpleado(Empleado empleado)
        {
            //Método público para actualizar un empleado
            connection.Update(empleado);
        }
        public void DeleteEmpleado(Empleado empleado)
        {
            //Método público para eliminar un empleado
            connection.Delete(empleado);
        }
        public Empleado GetEmpleado(int IDEmpleado)
        {
            //Obtengo un objeto empleado
            return connection.Table<Empleado>().FirstOrDefault(c => c.IDEmpleado == IDEmpleado);
        }
        public List<Empleado> GetEmpleados()
        {
            var lista = connection.Table<Empleado>().Select(c => c).OrderBy(c => c.Nombre).ToList();
            return lista;
            //Obtengo una lista de empleados
            //return connection.Table<Empleado>().Select(c=>c).OrderBy(c=>c.Nombre).ToList();
        }

        public void Dispose()
        {   //Método para liberar recursos
            connection.Dispose();
        }
    }
}
