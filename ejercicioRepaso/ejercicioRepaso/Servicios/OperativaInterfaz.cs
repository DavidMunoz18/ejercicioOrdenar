using ejercicioRepaso.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioRepaso.Servicios
{
    internal interface OperativaInterfaz
    {
        public void darAltaCliente(List<ClienteDto> listaClientes);

        public void mostrar(List<ClienteDto> listaClientes);
    }
}
