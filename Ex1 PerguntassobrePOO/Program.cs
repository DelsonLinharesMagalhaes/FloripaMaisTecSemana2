﻿using System;
using System.Globalization;

namespace Ex1_PerguntassobrePOO
{
    class Program{
        static void Main(string[] args){
            
            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Funcionario: "+ func);

            Console.WriteLine();
            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            
            func.AumentarSalario(porcent);

            Console.WriteLine("Dados atualizados: " + func);
        }
    }
}


