using Arquivos.Views;
using manipulacao_de_datas;

/*
e exportação do arquivo.txt
*/



int option = 0;

do
{
    Console.WriteLine("*******************************************");
    Console.WriteLine("Programa para leitura e exportação de dados");
    Console.WriteLine("*******************************************");
    Console.WriteLine("");
    Console.WriteLine("Dias Especiais!");
    Console.WriteLine("Dia 15 de Setembro");
    Console.WriteLine("Dia 4 de Outubro");
    Console.WriteLine("Dia 18 de Outubro");
    DateTime data = DateTime.Now;
    if (data.DayOfYear == 365)
    {
        Console.WriteLine("Dia do Medico");
        Console.WriteLine("Dia do Animal");
        Console.WriteLine("Dia do Cliente");
        Console.WriteLine(data.DayOfWeek);
    }
    else
        Console.WriteLine("Hoje é um dia normal");
    Console.WriteLine(data.ToLocalTime());
    Console.WriteLine("1 - Clientes");
    Console.WriteLine("2 - Animais");
    Console.WriteLine("3 - Médicos");
    
    option = Convert.ToInt32(Console.ReadLine());

    switch(option)
    {
        case 1 :
            Console.WriteLine("Opção Clientes");
            ClientView clientView = new ClientView();
        break;

        case 2 :
            Console.WriteLine("Opção Animais");
            AnimalsView animalsViews = new AnimalsView();
        break;
        
        case 3 :
            Console.WriteLine("Opção Médicos");
            MedicosView medicoViews = new MedicosView();
        break;
    }




}
while(option > 0);