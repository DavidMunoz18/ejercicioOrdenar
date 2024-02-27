using ejercicioRepaso.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioRepaso.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void darAltaCliente(List<ClienteDto> listaClientes)
        {
            ClienteDto cliente = aniadirCliente();

            listaClientes.Add(cliente);
        }

        public void mostrar(List<ClienteDto> listaClientes)
        {
            foreach(ClienteDto cliente in listaClientes)
            {
                
                Console.WriteLine("---------------------------------");
                Console.WriteLine(cliente.NombreCompleto);
                Console.WriteLine(cliente.Nombre);
                Console.WriteLine(cliente.Apellido1);
                Console.WriteLine(cliente.Apellido2);
                Console.WriteLine(cliente.Edad);
                Console.WriteLine("---------------------------------");
                
            }
            ordenar(listaClientes);
        }

        private ClienteDto aniadirCliente()
        {
            ClienteDto cliente = new ClienteDto();

            Console.WriteLine("Introduce el nombre completo");
            cliente.NombreCompleto = Console.ReadLine();

            Console.WriteLine("Introduce la edad");
            cliente.Edad = Convert.ToInt32(Console.ReadLine());

            return cliente;
        }

        private void ordenar(List<ClienteDto> clientes)
        {
            for (int i = 0; i < clientes.Count - 1; i++)
            {
                for (int j = 0; j < clientes.Count - 1 - i; j++)
                {
                    if (clientes[j].Edad < clientes[j + 1].Edad)
                    {
                        ClienteDto aux = clientes[j];
                        clientes[j] = clientes[j + 1];
                        clientes[j + 1] = aux;
                    }
                }
            }
        }
        
    }
}
