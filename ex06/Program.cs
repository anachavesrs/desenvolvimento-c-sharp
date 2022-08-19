using System;

namespace ex06 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = {10, 15, 20, 25};
            Console.WriteLine("A média é: " + calculaMedia(numeros));
            Console.WriteLine("A mediana é: " + calculaMediana(numeros));
             Console.WriteLine("A moda é: " + calculaModa(numeros));
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


        static double calculaModa(double[] numeros){

            double[] repeticoes = new double[numeros.Length];

            for (int i = 0; i < numeros.Length; i++)
            {
                double atual = numeros[i];
                int cont = 0;
                for (int j = 0; j < numeros.Length; j++)
                {
                    if(numeros[j] == atual){
                        cont ++;
                    }
                }

                repeticoes[i] = cont;
            }

            int maior = 0;
            for (int i = 1; i < repeticoes.Length; i++)
            {
                if(repeticoes[i] > repeticoes[i -1]){
                    maior =  i;
                }
            }

            return numeros[maior];
        }
    }
}