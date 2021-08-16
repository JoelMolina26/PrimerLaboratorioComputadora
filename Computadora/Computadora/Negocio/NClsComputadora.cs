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

            return " La computadora con memoria Ram de" + computadora.Ram + "procesador" + computadora.Procesador + "Encender computadora";

        }

        public String Apagar(ClsComputadora computadora)
        {
            return "La computadora con memoria Ram" + computadora.Ram + "procesador" + computadora.Procesador + "Apagar computadora";

        }
        public String Reiniciar(ClsComputadora computadora)
        {
            return "La computadora con memoria Ram" + computadora.Ram + "procesador" + computadora.Procesador + "Reiniciar computadora";


        }
        public String Suspender(ClsComputadora computadora)
        {
            return "La computadora con memoria Ram" + computadora.Ram + "procesador" + computadora.Procesador + "Suspender computadora";
        }
    }
}
