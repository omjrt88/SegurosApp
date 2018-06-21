namespace SegurosApp.Controllers
{
    using System.Net;
    using System.Web.Http;
    using SegurosApp.Business;
    using SegurosApp.Models;

    public class ClientController : ApiController
    {
        // GET: api/Client
        public IHttpActionResult Get()
        {
            try
            {
                ClientBusiness business = new ClientBusiness();
                return this.Content(HttpStatusCode.OK, business.Get());
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        // GET: api/Client/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                ClientBusiness business = new ClientBusiness();
                return this.Content(HttpStatusCode.OK, business.Get(id));
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        // POST: api/Client
        public void Post([FromBody]Client client)
        {
            try
            {
                ClientBusiness business = new ClientBusiness();
                business.Create(client);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        // PUT: api/Client/5
        public void Put(int id, [FromBody]Client client)
        {
            try
            {
                ClientBusiness business = new ClientBusiness();
                business.Update(client);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        // DELETE: api/Client/5
        public void Delete(int id)
        {
            try
            {
                ClientBusiness business = new ClientBusiness();
                business.Delete(id);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
