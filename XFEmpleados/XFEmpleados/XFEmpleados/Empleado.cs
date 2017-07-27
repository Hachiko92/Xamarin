﻿using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFEmpleados
{
    public class Empleado
    {
        [PrimaryKey,AutoIncrement]
        public int IDEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaContrato { get; set; }
        public decimal Salario { get; set; }
        public bool Activo { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", 
                Nombre, Apellido, FechaContrato, Salario, Activo);
        }
    }
}
