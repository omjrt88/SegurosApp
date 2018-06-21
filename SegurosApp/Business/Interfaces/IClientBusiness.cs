namespace SegurosApp.Business.Interfaces
{
    using System.Collections.Generic;
    using SegurosApp.Models;

    public interface IClientBusiness
    {
        void Create(Client client);

        IEnumerable<Client> Get();

        Client Get(int id);

        void Update(Client client);

        void Delete(int id);
    }
}
