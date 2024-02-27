using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioRepaso.Dtos
{
    internal class ClienteDto
    {
        long id;
        string nombre = "aaaaa";
        string apellido1 = "aaaaa";
        string apellido2 = "aaaaa";
        string nombreCompleto = "aaaaa";
        int edad = 11111;

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public int Edad { get => edad; set => edad = value; }

        

        public ClienteDto(long id, string nombreCompleto, int edad)
        {
            this.id = id;
            this.nombreCompleto = nombreCompleto;
            this.edad = edad;
            string[] nombreSeparado = nombreCompleto.Split(" ");
            this.nombre = nombreSeparado[0];
            this.apellido1 = nombreSeparado[1];
            this.apellido2 = nombreSeparado[2];
        }
    }
}
