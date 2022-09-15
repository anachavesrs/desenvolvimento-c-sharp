using System;

namespace aula05 // Note: actual namespace depends on the project name.
{
     class Usuario
    {

            string username;
            string hash;

        public Usuario(string u, string p){
            username = u;
            ApplyHash(p);
        }


        void ApplyHash(string password){

        //TODO aplicar hash
      }


      public string getUsername(){

        return username;
      }

      public string setUsername(){

        return hash;
      }
    }


}