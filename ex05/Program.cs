using System;

namespace ex5 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número para calcular a sequencia de Fibonacci: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(fibonacciN(x));
        }

        static int fibonacciN(int x){
         if (x == 0) {
        int resultado = 0;
        return resultado;

        }else if (x == 1){
        int resultado = 1;
        return resultado; 

        }else{
        return fibonacciN(x-1) + fibonacciN(x-2);
       
   }
}
    }
}

