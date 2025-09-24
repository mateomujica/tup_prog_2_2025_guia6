using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Persona:IComparable
    {
        protected string nombre; 

        public string Nombre { get { return nombre; } }

        public Persona (string nombre)
        {
            this.nombre = nombre;
        }

        virtual public string Describir()
        {
            return $"{nombre}";
        }

        public int CompareTo(object? obj)
        {
            Persona persona = obj as Persona;

            if (persona != null)
            {
                return persona.nombre.CompareTo(this.nombre);
            }
            return -1;
               
        }
    }
}
