using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int escolha = int.Parse(Console.ReadLine());           

            switch(escolha)
            {                
                case 1:
                    Console.WriteLine("Voçê escolheu a opção 1");
                    break;
                case 2:
                    Console.WriteLine("Voçê escolheu a opção 2");
                    break;
                case 3:
                    Console.WriteLine("Voçê escolheu a opção 3");
                    break;
                case 4:
                    Console.WriteLine("Voçê escolheu a opção 4");
                    break;

                default:
                    Console.WriteLine("Nenhuma das Opções foram escolhidas.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
