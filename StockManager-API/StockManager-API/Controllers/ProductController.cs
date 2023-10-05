using Microsoft.AspNetCore.Mvc;
using StockManager_API.Services;

namespace StockManager_API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly MovementStockService _service;

        public ProductController(ILogger<ProductController> logger, MovementStockService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet("busca-produto/{id}", Name = "GetProduct")]
        public IActionResult Get(int id)
        {
            var product =_service.GetProduct(id);
            return product != null ? Ok(product) : NotFound("Produto não encontrado");
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }
    }
}
