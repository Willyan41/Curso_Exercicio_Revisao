using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medidada = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é $ {1}", produto1, preco1.ToString("F2"));
            Console.WriteLine("{0}, cujo preço é $ {1}", produto2, preco2.ToString("F2"));
            Console.WriteLine("");
            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);
            Console.WriteLine("Medida com oito casas decimais: {0}", medidada);
            Console.WriteLine("Medida com oito casas decimais: {0}", medidada.ToString("F3"));
            Console.WriteLine("Medida com oito casas decimais: {0}", medidada.ToString("F2",CultureInfo.InvariantCulture));




        }
    }
}
