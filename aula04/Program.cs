using System;
using System.IO;

namespace aula04
{
    class Program
    {

        static bool cadastrar(string username, string password){
            string linha = username + ":" + password;

            File.WriteLi
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo!");
            Console.WriteLine("Digite 1 para logar");
            Console.WriteLine("Digite 2 para cadastrar");
            Console.WriteLine("Digite 2 para sair");

            bool sair = false;
            while (!sair)
            {
                int opcao = 0;
                try{
                     opcao = int.Parse(Console.ReadLine());
                } catch (Exception erro){

                }
              
               switch (opcao){
                   case 1:
                   //TODO logar
                   break;
                   case 2:
                  Console.WriteLine("Digite um nome de usuário");
                  string username = Console.ReadLine();

                  Console.WriteLine("Digite uma senha");
                  string password = Console.ReadLine();

                  Console.WriteLine("Confirme a senha");
                  string confirm = Console.ReadLine();

                  if(password != confirm){
                      Console.WriteLine("senhas diferentes");
                  } else{
                      if(cadastrar(username, password)){

                          Console.WriteLine("Cadastro efetuado");
                      }else{
                          Console.WriteLine("Não foi possível cadastrar");
                      }
                  }

                   break;
                   case 3:
                   sair = true;
                   break;

                   default:
                   Console.WriteLine("Opção, inválida, tente novamente.");
                   break;
               }

        }
    }
    }
}
