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
    public class AttributeController : TableController<Attribute>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            boephotoarchiveContext context = new boephotoarchiveContext();
            DomainManager = new EntityDomainManager<Attribute>(context, Request);
        }

        // GET tables/Attribute
        public IQueryable<Attribute> GetAllAttribute()
        {
            return Query(); 
        }

        // GET tables/Attribute/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Attribute> GetAttribute(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Attribute/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Attribute> PatchAttribute(string id, Delta<Attribute> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Attribute
        public async Task<IHttpActionResult> PostAttribute(Attribute item)
        {
            Attribute current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Attribute/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteAttribute(string id)
        {
             return DeleteAsync(id);
        }
    }
}
