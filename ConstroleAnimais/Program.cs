using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstroleAnimais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a;
            int tl = 0;
            Animal[] animais = new Animal[10];
            int tlCachorro = 0, tlGato = 0, tlPeixe = 0;
            int tipoAnimal = 0;


            Console.WriteLine("CONTROLE DE ANIMAIS");

            //Leitura da quantidade de animais
            try
            {
                Console.Write("Quantos animais deseja informar (Máx 10): ");
                tl = int.Parse(Console.ReadLine());
                if (tl > 20) tl = 20;
            }
            catch
            {
                tl = 0;
            }
           
            for(int i = 0; i < tl; i++)
            {

                //Primeiro animal
                a = new Animal();

                Console.Write("Informe o nome do "+(i+1)+ "º animal: ");
                a.Nome = Console.ReadLine();

                Console.Write("Informe o tipo do "+(i+1)+ "º animal(Cachorro - 0; Gato = 1; Peixe = 2): ");
                try
                {
                    tipoAnimal = int.Parse(Console.ReadLine());
                    if (tipoAnimal < 0 || tipoAnimal > 2) tipoAnimal = 2;
                }
                catch
                {
                    tipoAnimal = 2;
                }

                a.Tipo = (TipoAnimal)tipoAnimal;
                if (a.Tipo == TipoAnimal.Cachorro) tlCachorro++;
                if (a.Tipo == TipoAnimal.Gato) tlGato++;
                if (a.Tipo == TipoAnimal.Peixe) tlPeixe++;
                //armazenar o animal no vetor
                animais[i] = a;
            }



            Console.WriteLine("Quantidade de animais");
            Console.WriteLine($"Cachorros:  " + tlCachorro + "\nGatos: " + tlGato + "\nPeixes: " + tlPeixe);

            Console.ReadKey();

        }
    }
}
