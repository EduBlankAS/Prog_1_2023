using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Controllers
{
    public class ClientController
    {   
        private string directoryName = "ReportFiles";

        private string fileName = "Clients.txt";

        public List<Client> List()
        {
            return DataSet.Clients;
        }

        public bool Insert(Client client)
        {
            if(client == null)
                return false;
            
            if(client.Id <= 0)
                return false;
            
            if(string.IsNullOrWhiteSpace(client.FirstName))
                return false;
            
            DataSet.Clients.Add(client);
            return true;

        }

        public bool ExportToTextFile()
        {
            if(!Directory.Exists(directoryName))
                Directory.CreateDirectory(directoryName);
            
            string fileContent = string.Empty;
            foreach(Client c in DataSet.Clients)
            {
                fileContent += $"{c.Id};{c.CPF};{c.FirstName};{c.LastName};{c.Email}";
                fileContent += "\n";
            }
            
            try
            {
                StreamWriter sw = File.CreateText( $"{directoryName}\\{fileName}" );

                sw.Write(fileContent);
                sw.Close();     
            }
            catch(IOException ioEx)
            {
                Console.WriteLine("Erro ao manipular o arquivo.");
                Console.WriteLine(ioEx.Message);
                return false;
            }
            return true;
        }

        public bool ImportFromTxtFile()
        {
            try
            {
                StreamReader sr = new StreamReader(
                $"{directoryName}\\{fileName}"
            );

            string line = string.Empty;
            line = sr.ReadLine();
            while(line != null)
            {
                Client client = new Client();
                string[] clientData = line.Split(';');
                client.Id = Convert.ToInt32( clientData[0]);
                client.CPF = clientData[1];
                client.FirstName = clientData[2];
                client.LastName = clientData[3];
                client.Email = clientData[4];

                DataSet.Clients.Add(client);

                line = sr.ReadLine();
            }

            return true;

            }
            catch(Exception ex)
            {
                Console.WriteLine("Oooops. Ocorreu um erro ao tentar importar os dados.");
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public int GetNextId()
        {
            int tam = DataSet.Clients.Count;

            if(tam > 0)
            {
                return DataSet.Clients[tam - 1].Id + 1;
            }
            else
                return 1;
        }        
    }
}