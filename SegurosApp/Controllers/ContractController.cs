namespace SegurosApp.Controllers
{
    using System.Net;
    using System.Web.Http;
    using SegurosApp.Business;
    using SegurosApp.Models;

    public class ContractController : ApiController
    {
        // GET: api/Contract
        public IHttpActionResult Get()
        {
            try
            {
                ContractBusiness business = new ContractBusiness();
                return this.Content(HttpStatusCode.OK, business.Get());
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        // GET: api/Contract/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                ContractBusiness business = new ContractBusiness();
                return this.Content(HttpStatusCode.OK, business.Get(id));
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        // POST: api/Contract
        public void Post([FromBody]Contract contract)
        {
            try
            {
                ContractBusiness business = new ContractBusiness();
                business.Create(contract);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        // PUT: api/Contract/5
        public void Put([FromBody]Contract contract)
        {
            try
            {
                ContractBusiness business = new ContractBusiness();
                business.Update(contract);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        // DELETE: api/Contract/5
        public void Delete(int id)
        {
            try
            {
                ContractBusiness business = new ContractBusiness();
                business.Delete(id);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
