using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstroleAnimais
{
    public class Animal
    {
        private string _nome;
        private string _tipo;

        public string Nome
        {
            get { return _nome; }

            set
            {
                _nome = value.ToUpper();
            }
        }

        public string Tipo
        {
            get { return _tipo; }

            set
            {
                if(value == "cachorro" || value == "gato" || value == "peixe")
                {
                    _tipo = value;
                }
                else
                {
                    Console.WriteLine("Tipo de animal inválido");
                }
            }
        }
    }
}
