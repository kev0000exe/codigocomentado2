using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq
{

    //Enfermero por herencia esta conectado con empleado solo  obtendriamos la propiedad nombre 
    public class Enfermero : Empleado
    {
        public string nombre { get; set; }
    }
}
