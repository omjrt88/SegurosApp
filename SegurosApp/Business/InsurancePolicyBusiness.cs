namespace SegurosApp.Business
{
    using System.Collections.Generic;
    using SegurosApp.Business.Interfaces;
    using SegurosApp.DAL;
    using SegurosApp.Models;

    public class InsurancePolicyBusiness : IInsurancePolicyBusiness
    {
        private static PolicyData policyData = new PolicyData();

        public void Create(Policy policy)
        {
            policyData.Create(policy);
        }

        public void Delete(int id)
        {
            policyData.Delete(id);
        }

        public IEnumerable<Policy> Get()
        {
            return policyData.Get();
        }

        public Policy Get(int id)
        {
            return policyData.Get(id);
        }

        public void Update(Policy policy)
        {
            policyData.Update(policy);
        }
    }
}