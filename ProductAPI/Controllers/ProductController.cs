using Microsoft.AspNetCore.Mvc;
using Product.Application.IAppService;
using Product.Data.Infrastructure.Dto;

namespace Enterprise.Events.Presentation.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _ProductService;
        public ProductController(IProductService productService)
        {
            _ProductService = productService;
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductDto ProductDto)
        {
            return Ok(await _ProductService.Add(ProductDto));
        }
        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _ProductService.GetById(id));
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _ProductService.Delete(id));
        }
        [HttpPut]
        public async Task<IActionResult> Update(ProductDto dto)
        {
            return Ok(await _ProductService.Update(dto));
        }
        [HttpPost]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _ProductService.GetList());
        }

    }
}