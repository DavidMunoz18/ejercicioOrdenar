using ejercicioRepaso.Dtos;
using ejercicioRepaso.Servicios;

namespace ejercicioRepaso.Controladores
{
    class program
    {
        public static void Main(string[] args)
        {
            List<ClienteDto> listaClientes = new List<ClienteDto>();
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();

            bool cerrarMenu = false;

            int opcion;

            while(!cerrarMenu)
            {
                opcion = mi.mostrarMenuYSeleccion();

                switch (opcion)
                {
                    case 0:
                        cerrarMenu |= true;
                        break;
                    case 1:
                        oi.darAltaCliente(listaClientes);
                        break;
                    case 2:
                        oi.mostrar(listaClientes);
                        break;
                }
            }
        }
    }
}
