using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp9Luna
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

namespace Mis_clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Tipo { get; set; }
        private int DNI { get; set; }

    }
    abstract class Mamifero
    {
        private string Nombre { get; set; }
        public List<Mamifero> Especies { get; set; }
        public Mamifero()
        {
            List<Mamifero> _especies = new List<Mamifero>();
            this.Especies = _especies;
        }
    }
    class Perro : Mamifero
    {
        public string Hablar()
        {
            return "guau guau";
        }
    }
    class Gato : Mamifero
    {
        public string Hablar()
        {
            return "miau miau";
        }
    }

    class l_digitales
    {
        public string Titulo { get; set; }
        public int Hojas { get; set; }
        public float Precio { get; set; }
        public List<l_digitales> Catalogo { get; set; }
        public l_digitales()
        {
            List<l_digitales> _librosd = new List<l_digitales>();
            this.Catalogo = _librosd;
            if (this.Hojas > 200)
            {
                this.Precio = this.Precio * 1,1;
            }
            else if (this.Hojas > 102)
            {
                this.Precio = this.Precio * 1,09;
            }
            else if (this.Hojas > 10)
            {
                this.Precio = this.Precio * 1,03;
            }
        }

    }
    class l_impresos
    {
        public string Titulo { get; set; }
        public int Hojas { get; set; }
        public float Precio { get; set; }
        public List<l_impresos> Catalogo { get; set; }
        public l_impresos()
        {
            List<l_impresos> _librosf = new List<l_impresos>();
            this.Catalogo = _librosf;
        }

    }
}
}
