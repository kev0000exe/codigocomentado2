using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq
{
    //por la herencia estaba conectado con empleado y solo tenemos la propiedad nombre 
    public class Medico : Empleado
    {
        public string nombre { get; set; }
    }
}
