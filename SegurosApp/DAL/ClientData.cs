namespace SegurosApp.DAL
{
    using System.Collections.Generic;
    using System.Linq;
    using SegurosApp.DAL.Interfaces;
    using SegurosApp.Models;

    public class ClientData : IClientData
    {
        public void Create(Client client)
        {
            using (InsuranceContext context = new InsuranceContext())
            {
                context.Clients.Add(client);
                context.SaveChanges();
            }
        }

        public IEnumerable<Client> Get()
        {
            using (InsuranceContext context = new InsuranceContext())
            {
                return context.Clients.ToList();
            }
        }

        public Client Get(int id)
        {
            using (InsuranceContext context = new InsuranceContext())
            {
                return context.Clients.Where(c => c.Id == id).FirstOrDefault();
            }
        }

        public void Update(Client client)
        {
            using (InsuranceContext context = new InsuranceContext())
            {
                var current = context.Clients.Find(client.Id);
                if (current == null)
                {
                    return;
                }

                context.Entry(current).CurrentValues.SetValues(client);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (InsuranceContext context = new InsuranceContext())
            {
                var current = context.Clients.Find(id);
                context.Clients.Remove(current);
                context.SaveChanges();
            }
        }
    }
}