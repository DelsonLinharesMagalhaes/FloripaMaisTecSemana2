using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Text;


namespace Ex8Pessoa
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade;

        public Pessoa(string nome, DateTime dataNascimento){
            Nome = nome;
            DataNascimento = dataNascimento;
        }

        private void CalcularIdade(){
            var dataAtual = DateTime.Now;
            Idade = dataAtual.Year - DataNascimento.Year;
            if (DataNascimento > dataAtual.AddYears(-Idade))
            {
                Idade--;
            }
        }

        public void MostrarIdade(){
            CalcularIdade();
            Console.WriteLine($"{Nome} tem a idade de {Idade}");
        }
    }
    
}