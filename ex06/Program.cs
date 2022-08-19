using System;

namespace ex06 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = {20, 80, 60, 50};
            Console.WriteLine("A média é: " + calculaMedia(numeros));
            Console.WriteLine("A mediana é: " + calculaMediana(numeros));
        }

        static double calculaMedia(double []numeros){
            double soma = 0;
                for(int i = 0; i < numeros.Length; i ++){
                    soma += numeros[i];
                }
                double media = soma / numeros.Length;
                return media;
                
        }

        static double calculaMediana( double []numeros){

            Array.Sort(numeros);
            int meio = numeros.Length / 2;
            if ((numeros.Length % 2) == 0){

                return(numeros[meio] + numeros[meio -1]) / 2;
            }else{
                
                return numeros[meio];
            }
            
            
        }
    }
}