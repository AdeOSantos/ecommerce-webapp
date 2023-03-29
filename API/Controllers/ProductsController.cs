using API.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext context;

        public ProductsController (StoreContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public string GetProducts()
        {
            return "this will be a list of products";
        }
        
        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return "this will be a product";
        }



    }
}