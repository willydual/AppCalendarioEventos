using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calendario
{
    interface IimprimirEventos
    {
        void ImprimirListaEventos(LeerAchivo ob, string rutaDelArchivo);
    }
}
