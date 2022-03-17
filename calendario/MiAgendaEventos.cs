using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calendario
{
    class MiAgendaEventos
    {
        //LeerAchivo leer = new LeerAchivo();
        //leer.leerArchivo();
        //DateTime fechaEvento = DateTime.Parse("08/03/2022");
        //TimeSpan diasPasados = DateTime.Now.Subtract(fechaEvento);
        //TimeSpan mesesPasados = DateTime.Now.Subtract(fechaEvento);
        //Console.WriteLine("Sesión de coucheo buenas prácticas " + diasPasados.Days + " días");
        //Console.WriteLine("Sesión de coucheo buenas prácticas " + mesesPasados + " días");
        //if(diasPasados.Days==0){
        //    Console.WriteLine("Es hoy quedan " + diasPasados.Days);
        //}else if(diasPasados.Days<0){

        //}else{
        //    Console.WriteLine("Sesión de coucheo buenas prácticas " + diasPasados.Days + " días");
        //}
        LeerAchivo lectura = new LeerAchivo();
        public void agenda(){
            foreach (string evento in lectura.GeneraListaEventos(@"eventos.txt"))
            {
                DateTime fechaEvento = DateTime.Parse(evento);
                TimeSpan dias = DateTime.Now.Subtract(fechaEvento);
                Console.WriteLine("Nombre del Evento ocurrirá dentro de " + dias.Days);
            }
        }
    }
}
