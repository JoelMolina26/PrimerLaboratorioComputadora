using Computadora.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora.Negocio
{
    class NClsComputadora
    {
        public String Encender(ClsComputadora computadora)
        {

            return " La computadora con memoria ram de" + computadora.Ram + "procesador" + computadora.Procesador + "Esta Encendida";


        }
    }
}
