namespace SegurosApp.DAL.Interfaces
{
    using System.Collections.Generic;
    using SegurosApp.Models;

    public interface IPolicyData
    {
        void Create(Policy policy);

        IEnumerable<Policy> Get();

        Policy Get(int id);

        void Update(Policy policy);

        void Delete(int id);
    }
}
