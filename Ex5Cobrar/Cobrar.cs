using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex5Cobrar
{
    public class Cobrar
    {
        private decimal Valor { get; set; }
        private decimal Multa {get; set; }

        public Cobrar(decimal valor, decimal multa){
            Valor = valor;
            Multa = multa;
        }

        private decimal CalcularMulta(){
            return(Valor+Multa);
        }

        public void Calcular(){
            Console.WriteLine($"Valor cobrado {Valor}, multa {Multa}, valor total {CalcularMulta()}");
        }
    }
}