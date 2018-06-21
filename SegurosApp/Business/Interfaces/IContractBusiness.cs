namespace SegurosApp.Business.Interfaces
{
    using System.Collections.Generic;
    using SegurosApp.Models;

    public interface IContractBusiness
    {
        void Create(Contract contract);

        IEnumerable<Contract> Get();

        Contract Get(int id);

        void Update(Contract contract);

        void Delete(int id);
    }
}