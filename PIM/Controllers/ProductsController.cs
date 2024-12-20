//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;

//namespace PIM.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class ProductsController : ControllerBase
//    {
//        private readonly IProduct _product;
//        private readonly ILogger<ProductsController> _logger;

//        public ProductsController(
//            IProduct product,
//            ILogger<ProductsController> logger)
//        {
//            _product = product;
//            _logger = logger;
//        }

//        [HttpPost]
//        [Authorize(Roles = "Admin,Editor")]
//        public async Task<ActionResult<ProductDTO>> CreateProduct([FromBody] CreateProductDTO productDto)
//        {
//            try
//            {
//                var result = await _product.CreateProductAsync(productDto);
//                return CreatedAtAction(nameof(GetProduct), new { id = result.Id }, result);
//            }
//            catch (Exception ex)
//            {
//                _logger.LogError(ex, "Error creating product");
//                return StatusCode(500, "An error occurred while creating the product");
//            }
//        }

//        // Implement other endpoints...
//    }
//}
