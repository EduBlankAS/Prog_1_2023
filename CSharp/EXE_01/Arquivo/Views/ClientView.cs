using Arquivo.Data;
using Arquivo.Models;
using Arquivo.Controller;

namespace Arquivo.Views
{
    public class ClientView
    {
        private ClientControllers clientController;
        public ClientView()
        {
            clientController = new ClientControllers();
            this.Init();
        }

        public void Init()
        {
            Console.WriteLine("**********************");
            Console.WriteLine("VOCÊ ESTÁ EMC CLIENTES");
            Console.WriteLine("**********************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Cliente");
            Console.WriteLine("2 - Listar Clientes");
            Console.WriteLine("3 - Exportar Clientes");
            Console.WriteLine("4 - Importar Clientes");
            Console.WriteLine("");
            int option = 0;
            switch(option)
            {
                case 1 :
                    this.Insert();
                break;
                default:
                break;
            }
        }

        private void Insert()
        {
            Client client = new Client();
            client.Id = DataSet.Clients.Count + 1;

            Console.WriteLine("Informe o primeiro nome:");
            client.FirstName = Console.ReadLine();

              Console.WriteLine("Informe o sobrenome:");
            client.LastName = Console.ReadLine();

              Console.WriteLine("Informe o CPF:");
            client.CPF = Console.ReadLine();

              Console.WriteLine("Informe o Email:");
            client.Email = Console.ReadLine();
        }
    }
}