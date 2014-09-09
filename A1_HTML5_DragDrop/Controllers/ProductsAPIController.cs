using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using A1_HTML5_DragDrop.Models;
 
namespace A1_HTML5_DragDrop.Controllers
{
    public class ProductsAPIController : ApiController
    {
        ApplicationEntities ctx;

        public ProductsAPIController()
        {
            ctx = new ApplicationEntities(); 
        }

        [Route("Products")]
        public IEnumerable<Product> GetProducts()
        {
            return ctx.Products.ToList();
        }
    }
}
