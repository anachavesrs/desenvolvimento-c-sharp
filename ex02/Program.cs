using System;

namespace ex02 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double taxaDolar = 5.17;
            double taxaEuro = 6.17;
            double taxaPesoArgentino = 0.05;
            double conversaoDolar = 0;
            double ConversaoEuro = 0;
            double ConversaoPesoArgentino = 0;

            Console.WriteLine("Exercício 2 da lista");
            Console.WriteLine("Algoritmo de conversão monetária em C#");
            Console.WriteLine("Informe o valor em real: ");
            double real = Convert.ToDouble(Console.ReadLine());

            conversaoDolar = real / taxaDolar;
            ConversaoEuro = real / taxaEuro;
            ConversaoPesoArgentino = real / taxaPesoArgentino;

            Console.WriteLine(" A conversão do valor informado em dólar é " + conversaoDolar + "\n Em euro é " + ConversaoEuro + "\n Em peso argentino é: " + ConversaoPesoArgentino);
            

        }
    }
}