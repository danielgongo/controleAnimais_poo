using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstroleAnimais 

{
    public enum TipoAnimal {Cachorro, Gato, Peixe};
    public class Animal
    {
        public Animal()
        {
            this.Nome = "";
            this.Tipo = 0;
        }

        public Animal(string nome, TipoAnimal tipo )
        {
            this.Nome = nome;
            this.Tipo = tipo;
        }

        private string _nome;
        private TipoAnimal _tipo;

        public string Nome
        {
            get { return _nome; }

            set
            {
                _nome = value.ToUpper();
            }
        }

        public TipoAnimal Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
           
        }
    }
}
