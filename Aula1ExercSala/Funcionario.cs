public class Funcionario // Classe
{
    private int id; // variavel private, roda localmente
    public string Nome { get; set; } // propriedade publica
    public DateTime DataNascimento { get; set; } // propriedade publica
    public Departamento DepartamentoPessoal { get; set;}

    public void SalvaFuncionario(){ // Metodo nunca devolve valor em seu retorno
        Console.WriteLine("Passou por aqui");
        Console.WriteLine($"Id {id}");
        Console.WriteLine($"Descrição do departamento: {DepartamentoPessoal.Id}");
    }

     // Instancia da classe Deártamento
   
}