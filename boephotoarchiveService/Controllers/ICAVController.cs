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
    public class ICAVController : TableController<ICAV>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            boephotoarchiveContext context = new boephotoarchiveContext();
            DomainManager = new EntityDomainManager<ICAV>(context, Request);
        }

        // GET tables/ICAV
        public IQueryable<ICAV> GetAllICAV()
        {
            return Query(); 
        }

        // GET tables/ICAV/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<ICAV> GetICAV(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/ICAV/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<ICAV> PatchICAV(string id, Delta<ICAV> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/ICAV
        public async Task<IHttpActionResult> PostICAV(ICAV item)
        {
            ICAV current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/ICAV/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteICAV(string id)
        {
             return DeleteAsync(id);
        }
    }
}
