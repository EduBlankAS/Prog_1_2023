using Arquivos.Data;
using Arquivos.Models;
namespace Menu.Utils

{
    public static class Bootstrapper
    {
        public static void ChargeClients()
        {
            var c1 = new Client{
                Id = 1,
                FirstName = "Eduardo Blank",
                LastName = "Arrais Silva",
                CPF = "000.000.000-00",
                Email = "eduardoblankarraissilva@gmail.com",
            };
            DataSet.Clients.Add(c1);

            DataSet.Clients.Add(
                new Client{
                    Id = 2,
                    FirstName = "Eduardo",
                    LastName = "Blank",
                    CPF = "000.000-01",
                    Email= "eduardoblankarraissilva@gmail.com"
                }
            );
            DataSet.Clients.Add(
                new Client{
                    Id = 3,
                    FirstName = "Luiz",
                    LastName = "Henrique",
                    CPF = "000.000-02",
                    Email= "luizhenrique@gmail.com"
                }
            );
        }
    }
}