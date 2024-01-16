using Org.BouncyCastle.Asn1.X509.SigI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using ObligatorioProgramacion.model;
using ObligatorioProgramacionII.Modelo;

namespace ObligatorioProgramacion.model{

    public class Actor: Person{
        public int NroActor { get; }
       

        public Actor(){

        }

        public Actor(int nroActor, string nombre, string apellido, DateTime fechaDeNacimiento, string nacionalidad, string telefono, string mail)
        {
            NroActor = nroActor;
            Nombre = nombre;
            Apellido = apellido;
            FechaDeNacimiento = fechaDeNacimiento;
            Nacionalidad = nacionalidad;
            Telefono = telefono;
            Mail = mail;
        }
    }
}
