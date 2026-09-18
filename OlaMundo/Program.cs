Console.Clear();

//Declaração estatica de variáveis
string nome =  "Emerson";
int idade = 41;

//Declaração dinamica de variáveis
var sobreNome = "Oliveira";
var peso = 70.1f;

Console.WriteLine("Dados do usuario: ");
Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Idade: {idade}");
Console.WriteLine($"Peso: {peso}");
Console.WriteLine($"Nome completo: {nome} {sobreNome}");

//idade = idade + peso; Ilegal pois não é possível converter implicitamente tipo "float" em "int".
var resultado = Convert.ToString(idade) + " # " + sobreNome; //Dinamica
string resultado2 = Convert.ToString(idade) + " # " + sobreNome; //Statica

Console.WriteLine(resultado);
Console.WriteLine(resultado2);
Console.WriteLine("-----------------------------------");

Console.WriteLine("Digite o seu nome completo: ");
var nomeCompleto = Console.ReadLine();

Console.WriteLine("Nome completo digitado: " + nomeCompleto);




