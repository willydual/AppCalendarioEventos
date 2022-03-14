using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace calendario
{
    class LeerAchivo
    {
        //List<string> listOfNames = new List<string>()
        public List<String> listaEventos(){
            List<String> lista = new List<String>();
            string nombreArchivo = @"eventos.txt";
            using(StreamReader reader = new StreamReader(nombreArchivo))
            {
                string linea;
                while((linea = reader.ReadLine()) != null)
                {
                    lista.Add(linea);
                }
            }
            return lista;
        }

        public int longitud()
        {
            return tam;
        }
    }
}
