using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
            Console.WriteLine("Informe uma largura: ");
            double largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe uma altura");
            double altura = Convert.ToDouble(Console.ReadLine());
          
            Console.WriteLine("A area equivale a: " + CalculaArea(largura, altura));
            }catch (Exception erro){
                Console.WriteLine(erro.Message);
            }
        }

        static double CalculaArea(double largura, double altura)
        {
            return  largura * altura;
            
        }
    }
}
