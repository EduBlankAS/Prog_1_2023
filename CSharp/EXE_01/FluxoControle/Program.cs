
string password = "samur ai";
string retorno = string.Empty;

if( password.Length < 10  )
{
    retorno = @"Sua senha é muito curta.
              Use ao menos 10 caracteres";
}
else if ( password.Length > 15 )
    retorno = @"Sua senha é muito grande.
              Use entre 10 e 15 caracteres.";
else
    retorno = @"Sua senha está de acordo.";

Console.WriteLine(retorno);

// Checagem de valor e tipo
/*
    Em JavaScript podemos fazer assim:
    var a = "1";
    let b = 1;
    (a == b) retornará true
    (a === b) retornará false
*/

object o = 3;
int j = 4;
if( o is int i )
{
    Console.WriteLine( $"{i} x {j} = {i * j}" );
}
else
{
    Console.WriteLine( @"o não é um inteiro, portanto
                         não é possível multiplicar" );
}


// Comando Switch
int number = Random.Shared.Next(1,7);
Console.WriteLine($"Meu numero aleatório é {number}");
//WriteLine recebe um valor do tipo string
switch(number)
{
    case 1:
        Console.WriteLine("Um");
        break;
    case 2:
        Console.WriteLine("Dois");
        break;
    case 3:
    case 4:
        Console.WriteLine("Três ou Quatro");
        goto case 1;
    case 5:
        goto A_label;
    default:
        Console.WriteLine("Default");
        break;
}

Console.WriteLine("Depois do fim do switch");

A_label:
Console.WriteLine("Depois de A_label");
