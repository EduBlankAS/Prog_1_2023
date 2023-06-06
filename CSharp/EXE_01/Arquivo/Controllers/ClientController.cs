using Arquivo.Data;
using Arquivo.Models;
namespace Arquivo.Controller
{
    public class ClientControllers
    {
        public int GetNextId()
        {
            int tam = DataSet.Clients.Count;

           if( tam > 0 )
            return DataSet.Clients[tam - 1].Id + 1;
           else
            return 1;
        }
    }
}