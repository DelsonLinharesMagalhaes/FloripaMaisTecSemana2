using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex4Guitarra
{
    public class Guitarra
    {
        private static string Afinacao {get; set;}

        static Guitarra(){
            Afinacao = "Sol";
        }

        private static void TomAfinado(){
            Console.WriteLine($"A guitarra esta com afinação em {Afinacao}");
        }

        public void Tocar(){
            TomAfinado();
        }
        
         public void Tocar(string AfinacaoAtual){
            Afinacao =  AfinacaoAtual;
            TomAfinado();
        }

    }
}