using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioRepaso.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcion;
            Console.WriteLine("0. CERRAR MENU");
            Console.WriteLine("1. DAR DE ALTA CLIENTE");
            Console.WriteLine("2. MOSTRAR CLIENTE");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
    }
}
