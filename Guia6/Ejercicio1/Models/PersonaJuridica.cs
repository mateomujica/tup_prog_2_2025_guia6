using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
     public class PersonaJuridica : Persona
     {
        private string cuit;

        public PersonaJuridica(string nombre, string cuit) : base (nombre)
        {
            this.cuit = cuit;
        }

        public override string Describir()
        {
            return $"{cuit} / {nombre}";
        }
     }
}
