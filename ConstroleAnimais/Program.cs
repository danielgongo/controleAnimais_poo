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
            Animal a1 = new Animal();
            Animal a2 = new Animal();
            Animal a3 = new Animal();
           
            int tlCachorro = 0, tlGato = 0, tlPeixe = 0;

            Console.WriteLine("CONTROLE DE ANIMAIS");
           
            //Primeiro animal
            Console.Write("Informe o nome do 1º animal: ");
            a1.Nome = Console.ReadLine();

            Console.Write("Informe o tipo do 1º animal: ");
            a1.Tipo = Console.ReadLine();

            if (a1.Tipo.Equals("cachorro")) tlCachorro++;
            if (a1.Tipo.Equals("gato")) tlGato++;
            if (a1.Tipo.Equals("peixe")) tlPeixe++;

            //Segundo animal
            Console.Write("Informe o nome do 2º animal: ");
            a2.Nome = Console.ReadLine();

            Console.Write("Informe o tipo do 2º animal: ");
            a2.Tipo = Console.ReadLine();

            if (a2.Tipo.Equals("cachorro")) tlCachorro++;
            if (a2.Tipo.Equals("gato")) tlGato++;
            if (a2.Tipo.Equals("peixe")) tlPeixe++;

            //Terceiroo animal
            Console.Write("Informe o nome do 3º animal: ");
            a3.Nome = Console.ReadLine();

            Console.Write("Informe o tipo do 3º animal: ");
            a3.Tipo = Console.ReadLine();

            if (a3.Tipo.Equals("cachorro"))
            {
                tlCachorro++;
            }
            else if (a3.Tipo.Equals("gato"))
            {
                tlGato++;
            }
            else
            {
                tlPeixe++;
            }

            Console.WriteLine("Quantidade de animais");
            Console.WriteLine($"Cachorros:  " + tlCachorro + "\nGatos: " + tlGato + "\nPeixes: " + tlPeixe);

            Console.ReadKey();

        }
    }
}
