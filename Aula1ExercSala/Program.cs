Funcionario funcionario = new Funcionario();
funcionario.Nome = "Delson";
funcionario.DataNascimento = DateTime.Now;
funcionario.DepartamentoPessoal = new Departamento();
funcionario.DepartamentoPessoal.Id = 10;
funcionario.SalvaFuncionario();
