using SQLite.Net.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFEmpleados
{
    public interface IConfig
    {
        string DirectorioDB { get; }//Donde vamos a almacenar el directorio de la bb.dd
        ISQLitePlatform Plataforma { get; }//Con que plataforma vamos a trabajar
    }
}
