// Operadoradores Unários

int x = 5;
int incrementoPosfixado = x++; //6
incrementoPosfixado++;
x++; x = x+1;
int incrementoPrefixado = ++x;
Console.WriteLine(
    $"Posfixado: {incrementoPosfixado}"
);
Console.WriteLine(
    $"Prefixado: {incrementoPrefixado}"
);

//Como obter o tipo de uma variável

Type tipoDeInteiro = typeof(int);
Type tipoDeX = x.GetType();

//Como obter o nome de uma varáivel

string nomeDaVariavel = nameof(x);
int quantosBytes = sizeof(int);
Console.WriteLine("Nome da var: " + nomeDaVariavel);

//Operadores de atribuição
int p = 6;
p += 3; // equivalente a p = p + 3;
Console.WriteLine($"+={p}");
p -=3; // equivalente a p = p - 3;
Console.WriteLine($"-={p}");
p *=3; // equivalente a p = p * 3;
Console.WriteLine($"*={p}");
p /=3; // equialenrte a p = p / 3;
Console.WriteLine($"/={p}");

// Operadores Lógicos
bool a = true;
bool b = false;
WriteLine($"AND  | a    | b    ");
WriteLine($"a    |{a & a, -5} | {a & b, -5}");
WriteLine($"b    |{b & b, -5} | {b & b, -5}");
WriteLine();
WriteLine($"OR   | a    | b    ");
WriteLine($"a    |{a | a, -5} | {a | b, -5}");
WriteLine($"b    |{b | a, -5} | {b | b, -5}");
WriteLine();
WriteLine($"XOR  | a    | b    ");
WriteLine($"a    |{a ^ a, -5} | {a ^ b, -5}");
WriteLine($"b    |{b ^ a, -5} | {b ^ b, -5}");
WriteLine();

static bool FacaAlgo()
{
    WriteLine("Fazendo alguma coisa");
    return true;
}

WriteLine();
WriteLine($"a & FacaAlgo() = {a & FacaAlgo()}");
WriteLine($"b & FacaAlgo() = {b & FacaAlgo()}");
