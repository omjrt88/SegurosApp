namespace SegurosApp.Controllers
{
    using System.Net;
    using System.Web.Http;
    using SegurosApp.Business;
    using SegurosApp.Models;

    public class InsurancePolicyController : ApiController
    {
        // GET: api/InsurancePolicy
        public IHttpActionResult Get()
        {
            try
            {
                InsurancePolicyBusiness business = new InsurancePolicyBusiness();
                return this.Content(HttpStatusCode.OK, business.Get());
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        // GET: api/InsurancePolicy/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                InsurancePolicyBusiness business = new InsurancePolicyBusiness();
                return this.Content(HttpStatusCode.OK, business.Get(id));
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        // POST: api/InsurancePolicy
        public IHttpActionResult Post([FromBody]Policy policy)
        {
            try
            {
                InsurancePolicyBusiness business = new InsurancePolicyBusiness();
                business.Create(policy);
                return this.Content(HttpStatusCode.Created, policy);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        // PUT: api/InsurancePolicy/5
        public IHttpActionResult Put(int id, [FromBody]Policy policy)
        {
            try
            {
                InsurancePolicyBusiness business = new InsurancePolicyBusiness();
                business.Update(policy);
                return this.Content(HttpStatusCode.OK, policy);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        // DELETE: api/InsurancePolicy/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                InsurancePolicyBusiness business = new InsurancePolicyBusiness();
                business.Delete(id);
                return this.Content(HttpStatusCode.OK, id);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
