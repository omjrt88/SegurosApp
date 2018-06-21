namespace SegurosApp.DAL
{
    using System.Collections.Generic;
    using System.Linq;
    using SegurosApp.DAL.Interfaces;
    using SegurosApp.Models;

    public class PolicyData : IPolicyData
    {
        public void Create(Policy policy)
        {
            using (InsuranceContext context = new InsuranceContext())
            {
                context.Policies.Add(policy);
                context.SaveChanges();
            }
        }

        public IEnumerable<Policy> Get()
        {
            using (InsuranceContext context = new InsuranceContext())
            {
                return context.Policies.ToList();
            }
        }

        public Policy Get(int id)
        {
            using (InsuranceContext context = new InsuranceContext())
            {
                return context.Policies.Where(c => c.Id == id).FirstOrDefault();
            }
        }

        public void Update(Policy policy)
        {
            using (InsuranceContext context = new InsuranceContext())
            {
                var current = context.Policies.Find(policy.Id);
                if (current == null)
                {
                    return;
                }

                context.Entry(current).CurrentValues.SetValues(policy);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (InsuranceContext context = new InsuranceContext())
            {
                var current = context.Policies.Find(id);
                context.Policies.Remove(current);
                context.SaveChanges();
            }
        }
    }
}