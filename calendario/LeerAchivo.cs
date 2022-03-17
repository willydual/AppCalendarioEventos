using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace calendario
{
    public class LeerAchivo:IleerArchivo
    {
        public List<string> GeneraListaEventos(string nombreArchivo)
        {
            List<String> lista = new List<String>();
            using (StreamReader reader = new StreamReader(nombreArchivo))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    lista.Add(linea);
                }
            }
            return lista;
        }

        public int CalculaLongitudDeLista(List<string> lista)
        {
            return lista.Count;
        }

        public string[] DivideEventosEnFechas(List<string> listaEventos)
        {
            int i = 0;
            string texto = listaEventos[0];
            string[] cadenas = texto.Split(',');
            foreach(var sub in cadenas)
            {
                i = i + 1;
                Console.WriteLine("Cadenas " + sub);
            }

            return cadenas;
        }
    }
}
