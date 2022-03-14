using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calendario
{
    public class imprimirMisEventos
    {
        LeerAchivo lectura = new LeerAchivo();
        public void ImprimirListaEventos()
        {
            foreach (string envent in lectura.listaEventos())
            {
                Console.WriteLine(envent);
            }

        }

        public void RecuperaNombreEvento()
        {

        }
    }
}
