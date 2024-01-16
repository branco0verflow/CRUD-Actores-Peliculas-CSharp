using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioProgramacionII.Modelo
{
    public class Person
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }


        public Person()
        {
            
        }

        public Person(string nombre, string apellido, DateTime fechaDeNacimiento, string nacionalidad, string telefono, string mail)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaDeNacimiento = fechaDeNacimiento;
            Nacionalidad = nacionalidad;
            Telefono = telefono;
            Mail = mail;
        }
    }
}
