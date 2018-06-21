namespace SegurosApp.DAL.Interfaces
{
    using System.Collections.Generic;
    using SegurosApp.Models;

    public interface IClientData
    {
        void Create(Client client);

        IEnumerable<Client> Get();

        Client Get(int id);

        void Update(Client client);

        void Delete(int id);
    }
}
