using Microsoft.AspNetCore.Mvc;
using ProductApi.Dtos;
using ProductApi.Models;
using ProductApi.Services;

namespace ProductApi.Controllers;

[ApiController]
[Route("products")]
public class ProductsController(IProductService service) : ControllerBase
{
    [HttpGet]
    public Task<List<Product>> GetAll() => service.GetAllAsync();

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Product>> Get(int id) =>
        (await service.GetAsync(id)) is { } p ? Ok(p) : NotFound();

    [HttpPost]
    public async Task<ActionResult<Product>> Create([FromBody] ProductCreateDto dto)
    {
        var p = await service.CreateAsync(dto.Name, dto.Price, dto.Category);
        return CreatedAtAction(nameof(Get), new { id = p.Id }, p);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id) =>
        await service.DeleteAsync(id) ? NoContent() : NotFound();
}
