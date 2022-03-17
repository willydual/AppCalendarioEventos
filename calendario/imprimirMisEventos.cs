using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calendario
{
    public class imprimirMisEventos:IimprimirEventos
    {
        public void ImprimirListaEventos(LeerAchivo ob, string rutaDelArchivo)
        {
            foreach(string evento in ob.GeneraListaEventos(rutaDelArchivo))
            {
                Console.WriteLine(evento);
            }
        }
    }
}
