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
    public class Context_AttributeController : TableController<Context_Attribute>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            boephotoarchiveContext context = new boephotoarchiveContext();
            DomainManager = new EntityDomainManager<Context_Attribute>(context, Request);
        }

        // GET tables/Context_Attribute
        public IQueryable<Context_Attribute> GetAllContext_Attribute()
        {
            return Query(); 
        }

        // GET tables/Context_Attribute/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Context_Attribute> GetContext_Attribute(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Context_Attribute/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Context_Attribute> PatchContext_Attribute(string id, Delta<Context_Attribute> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Context_Attribute
        public async Task<IHttpActionResult> PostContext_Attribute(Context_Attribute item)
        {
            Context_Attribute current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Context_Attribute/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteContext_Attribute(string id)
        {
             return DeleteAsync(id);
        }
    }
}
