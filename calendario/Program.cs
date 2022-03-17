using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace calendario
{
    class Program
    {
        static void Main(string[] args)
        {
            imprimirMisEventos imprimir = new imprimirMisEventos();
            LeerAchivo ob = new LeerAchivo();
            imprimir.ImprimirListaEventos(ob,@"eventos.txt");
            Console.WriteLine(ob.CalculaLongitudDeLista(ob.GeneraListaEventos(@"eventos.txt")));
            Console.WriteLine(ob.DivideEventosEnFechas(ob.GeneraListaEventos(@"eventos.txt")));
            Console.ReadKey();
        }
    }
}
