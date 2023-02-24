using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex3MensagemCelular
{
    public class MensagemCelular     // Criando uma classe
    {
        public int Telefone { get; set; }     // Criação de propriedades publicas
        public string Mensagem { get; set; }

        public MensagemCelular(int telefone, string mensagem){        // Construtor com parâmetros
            Telefone = telefone;                                      // preencher as propriedades com valores vindos do construtor   
            Mensagem = mensagem;
        }

        public void Executar(){
            Console.WriteLine("Método Executado pelo Console");
            EnviarMensagemAoTelefone();

        }
        private void EnviarMensagemAoTelefone(){
            Console.WriteLine("Método privado executado na classe");
            Console.WriteLine("Telefone "+Telefone+" Mensagem "+ Mensagem);
        }

    }
}