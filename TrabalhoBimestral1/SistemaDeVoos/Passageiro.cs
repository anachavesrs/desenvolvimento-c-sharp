using System;

namespace ex03 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try{
            Console.WriteLine("Exercício 2 da lista, informar qual valor é maior");
            Console.WriteLine ("Informe um número inteiro: ");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Informe mais um número inteiro");
            int num2=  Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("O número maior é: " + ComparaMaior(num1, num2));
            }catch (Exception erro){
                Console.WriteLine(erro.Message);
            }
        }
        static double ComparaMaior(int num1, int num2)
        {
           if (num1 > num2)
           {
                return num1;
           } else{
                return num2;
           }
            
        }
    }
}