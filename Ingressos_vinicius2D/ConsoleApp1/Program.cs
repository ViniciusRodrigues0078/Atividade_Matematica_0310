//Feito por Diego Gabriel, Gabriel de Andrade e Vinícius Rodrigues, do 2°D
Console.WriteLine("Bem vindo ao SESI show!");
Console.WriteLine("Os ingressos custam R$30,00 para cada pessoa, mas para estudantes há um desconto de R$15,00.");
Console.WriteLine("Quantas pessoas irão entrar?");
int total_pessoas = int.Parse (Console.ReadLine());
Console.WriteLine("Destas pessoas, quantos são estudantes?");
int estudantes = int.Parse (Console.ReadLine());
int n_estudantes = (total_pessoas - estudantes);
int valor = (estudantes * 15) + (n_estudantes * 30);
Console.WriteLine("Considerando que o valor do ingresso para estudantes é R$15,00 , e para não estudantes é R$30,00 , logo,");
Console.WriteLine("o valor total será de: R$" + valor + ",00 , sendo: R$" + estudantes * 15 + ",00 o valor por conta dos estudantes e R$" + n_estudantes * 30 + ",00 por conta dos não estudantes.");