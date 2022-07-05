using System;
using System.Globalization;

namespace MERCADO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com o código: ");
            int cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a quantidade: ");
            int qnt = int.Parse(Console.ReadLine());

            double preco = 0;
            switch (cod)
            {
                case 0:
                    Console.WriteLine("Código inválido!");
                    break;
                case 1:
                    preco = 4.00;
                    Console.WriteLine("Cachorro quente.");
                    break;
                case 2:
                    preco = 4.00;
                    Console.WriteLine("X - Salada.");
                    break;
                case 3:
                    preco = 5.00;
                    Console.WriteLine("X-Bacon.");
                    break;
                case 4:
                    preco = 2.00;
                    Console.WriteLine("Torrada Simple.");
                    break;
                default:
                    preco = 1.00;
                    Console.WriteLine("Refrigerante.");
                    break;
            }

            Console.WriteLine("Total da compra é ", (preco * qnt).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
