using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calendario
{
    public interface IleerArchivo
    {
        List<String> GeneraListaEventos(string nombreArchivo);
        int CalculaLongitudDeLista(List<String> lista);
        string[] DivideEventosEnFechas(List<string> listaEventos);
    }
}
