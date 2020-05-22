using System;

namespace FGTS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Olá usuário, você precisa calcular seu FGTS.");

            Console.WriteLine(" Pressione enter para continuar:");

            Console.ReadKey();




            Console.WriteLine("Informe o seu salário atual em reais:");

            double salario = double.Parse(Console.ReadLine());



            Console.Write("A parcela do seu FGTS é: ");

            double resultado = (salario * 8 / 100);




            Console.Write( resultado);

            Console.WriteLine(" reais.");



            Console.ReadKey();
        }
    }
}
