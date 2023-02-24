using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2FichaInscricao
{
    // Criando uma classe
    public class FichaInscr
    {
        // Criação de propriedade publicas
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool MenorIdade { get; set; }

        //Construtor com parametros
        public FichaInscr(int id, string nome, DateTime dataNascimento, bool menorIdade){
         

            Id = id;                            //preencher as propriedades com valores vindos do construtor
            Nome = nome;
            DataNascimento = dataNascimento;
            MenorIdade = menorIdade;
        }

        public void ExibeFichaInscricao(){
            Console.WriteLine($"Inscrito número {Id}");
            Console.WriteLine($"Nome {Nome}");
            Console.WriteLine($"Nasceu dia {DataNascimento}");
            if (MenorIdade == true) { Console.WriteLine("Maior de Idade"); }
            else Console.WriteLine("Menor de Idade.");
        }
    }
}