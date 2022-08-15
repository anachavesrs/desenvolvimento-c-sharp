using System;

namespace ex04 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try{
            Console.WriteLine("Informe sua idade");
            int idade = Convert.ToInt16(Console.ReadLine());
            string resposta ;

            if (idade <= 13){
                 resposta = "Criança";
           } else if (idade <= 18){
                 resposta = "Adolescente";
           } else if (idade <= 60){
                 resposta = "Adulto";
           }else{
                resposta = "Idoso";
           }
            Console.WriteLine("De acordo com a sua idade, você está classificado como: " + resposta  );
            
            }catch (Exception erro){
                Console.WriteLine(erro.Message);
            }
        }

    }
}
