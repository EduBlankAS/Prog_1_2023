Console.WriteLine("Olá, seja bem vindo");
Console.WriteLine("Qual é o seu nome?");
string name = Console.ReadLine();
Console.WriteLine(
    $"Olá {name}  prazer conhecê-lo."
    );

// Declarar sem inicializar / primitivo
string message1;
// Declarar inicialiado / abstrato
String message2 = "Seu Nome Completo";
// Declarar string vazia
string message3 = String.Empty;
string message4 = "";

//Declaração com tipo implícito
var message5 = "Mensagem aleatória";

message1 = 
"Rogério Ceni;Pele;The Rock;Roberto Carlos";
var palavras = message1.Split(';');
foreach (var word in palavras)
{
    //Variável de escopa local do 
    //laço de repetição foreach
    int a = 10;
    Console.WriteLine(word);
}
