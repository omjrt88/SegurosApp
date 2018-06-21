namespace SegurosApp.Business
{
    using System.Collections.Generic;
    using SegurosApp.Business.Interfaces;
    using SegurosApp.DAL;
    using SegurosApp.Models;

    public class ClientBusiness : IClientBusiness
    {
        private static ClientData clientData = new ClientData();

        public void Create(Client client)
        {
            clientData.Create(client);
        }

        public void Delete(int id)
        {
            clientData.Delete(id);
        }

        public IEnumerable<Client> Get()
        {
            return clientData.Get();
        }

        public Client Get(int id)
        {
            return clientData.Get(id);
        }

        public void Update(Client client)
        {
            clientData.Update(client);
        }
    }
}