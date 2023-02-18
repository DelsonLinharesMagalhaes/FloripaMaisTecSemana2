Canil canil = new Canil();
canil.IdCanil = 101;
canil.Descricao = "Canil dos pequenos";
canil.Capacidade = 8;

Caes caes = new Caes();
caes.IdCaes = 95;
caes.Nome = "Fifi";
caes.Raca = "Pudle";

Console.WriteLine($"Identificação do canil:{canil.IdCanil}");
Console.WriteLine($"Descrição do canil: {canil.Descricao}");
Console.WriteLine($"Capacidade do canil: {canil.Capacidade}");

Console.WriteLine($"Identificação do cão: {caes.IdCaes}");
Console.WriteLine($"Nome do cão: {caes.Nome}");
Console.WriteLine($"Raça do cão: {caes.Raca}");

