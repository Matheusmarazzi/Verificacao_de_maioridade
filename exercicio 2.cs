using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome; int nasc, idade, ano;
            Console.WriteLine("Digite seu nome: ");
            nome=Console.ReadLine();
            Console.WriteLine("Digite o ano em que você nasceu: ");
            nasc = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano atual: ");
            ano = int.Parse(Console.ReadLine());
            idade= ano - nasc;
            if (idade > 18)
            {
                Console.Write("" + nome);
                Console.Write(" é Maior de idade");
            }
            else
            {

                Console.Write("" + nome);
                Console.Write(" não é Maior de idade");
            }

            
            Console.ReadKey();


            

            
            



        }
    }
}
