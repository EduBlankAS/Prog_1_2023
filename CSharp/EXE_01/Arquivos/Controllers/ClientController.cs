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