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
            Inicio:
            Console.Write("Digite um numero: ");
            int escolha = int.Parse(Console.ReadLine());           

            switch(escolha)
            {
                default:
                    goto Inicio;
                    break;

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
                    goto case 1;
            }

            Console.ReadKey();
        }
    }
}
