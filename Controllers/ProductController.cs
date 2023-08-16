using Backend.Model;
using Backend.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductInterface _product;
        public ProductController(ProductInterface _product) {
            this._product = _product;

        }
        [HttpGet("GetAllProducts")]

        public async Task<IActionResult> GetAll()
        {
            var _list=  await this._product.GetAll();
            if (_list != null)
            {

                return Ok(_list);
            }
            else {
                return NotFound();
            }
        }

        [HttpGet("GetById/{Product_Id}")]

        public async Task<IActionResult> GetById(int Product_Id)
        {
            var _list = await this._product.GetById(Product_Id);
            if (_list != null)
            {

                return Ok(_list);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost("Create")]

        public async Task<IActionResult> Create([FromBody] Products product)
        {
            var _result = await this._product.Create(product);
            return Ok(_result);
        }

        [HttpPut("Update")]

        public async Task<IActionResult> Update([FromBody] Products product, int Product_id)
        {
            var _result = await this._product.Update(product, Product_id);
            return Ok(_result);
        }

        [HttpDelete("Remove")]

        public async Task<IActionResult> Remove(int Product_id)
        {
            var _result = await this._product.Remove( Product_id);
            return Ok(_result);
        }

    }
}
