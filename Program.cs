using trilha_csharp_main.Models;

Pessoa pessoa1 = new Pessoa ();

pessoa1.Nome = "Dali";
pessoa1.Idade = 34;
pessoa1.Apresentar();

// string apresentação = "Seja bem vindo!";
// int quantidade = 5;
// double altura = 1.62;
// decimal preço = 20.55M;
// quantidade = quantidade + 1;

// Console.WriteLine (apresentação);
// Console.WriteLine ("Valor da variável quantidade: " + quantidade);
// Console.WriteLine ("Valor da variável altura: " + altura + "m");
// Console.WriteLine ("Valor da variável preço: R$ " + preço);

DateTime dataAtual = DateTime.Now;
//Console.WriteLine ("Data e hora: " + dataAtual.AddDays(5));
Console.WriteLine ("Data: " + dataAtual.ToString("dd/MM/yyyy"));