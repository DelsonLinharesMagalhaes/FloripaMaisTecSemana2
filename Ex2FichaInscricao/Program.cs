using Ex2FichaInscricao;

// Declarando a variável com a instância Ficha de Inscrição

DateTime Data = new DateTime(1968,07,02,23,45,00);

FichaInscr fichaInscr = new FichaInscr(10, "Molly Picklum", Data, true);
fichaInscr.ExibeFichaInscricao();
