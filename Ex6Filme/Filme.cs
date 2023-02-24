using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex6Filme
{
    public class Filme
    {
       public string NomeFilme { get; set; } 
       public string Categoria { get; set; }

       public Filme(string nomeFilme, string categoria){
        NomeFilme = nomeFilme;
        Categoria = categoria;
       }

       public void MostraFilme(){
            Console.WriteLine($"Nome do filme {NomeFilme} e categoria {Categoria}");
       }
    }
}