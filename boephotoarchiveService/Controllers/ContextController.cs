using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using boephotoarchiveService.DataObjects;
using boephotoarchiveService.Models;

namespace boephotoarchiveService.Controllers
{
    public class ContextController : TableController<Context>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            boephotoarchiveContext context = new boephotoarchiveContext();
            DomainManager = new EntityDomainManager<Context>(context, Request);
        }

        // GET tables/Context
        public IQueryable<Context> GetAllContext()
        {
            return Query(); 
        }

        // GET tables/Context/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Context> GetContext(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Context/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Context> PatchContext(string id, Delta<Context> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Context
        public async Task<IHttpActionResult> PostContext(Context item)
        {
            Context current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Context/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteContext(string id)
        {
             return DeleteAsync(id);
        }
    }
}
