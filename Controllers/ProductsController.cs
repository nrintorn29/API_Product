using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _service;

    public ProductsController(IProductService service) {_service = service;}

    [HttpGet]
    public ActionResult<IEnumerable<ProductResponseDto>> GetAll()
        => Ok(_service.GetAll().Select(p => p.ToResponse())); 
    
    [HttpGet("{id:int}")]
    public ActionResult<ProductResponseDto> GetById(int id)
    {
        var product = _service.GetById(id);

        if (product == null)
            return NotFound();
        
        return Ok(product.ToResponse());
    }

    [HttpGet("search")]
    public ActionResult<IEnumerable<ProductResponseDto>> Search(string name)
        => Ok(_service.Search(name).Select(p => p.ToResponse()));

    [HttpGet("expensive")]
    public ActionResult<IEnumerable<ProductResponseDto>> GetExpensive(decimal minPrice)
        => Ok(_service.GetExpensive(minPrice).Select(p => p.ToResponse()));

    [HttpPost]
    public ActionResult<CreateProductDto> Create(CreateProductDto dto)
    {
        var created = _service.Create(dto.ToEntity());

        return CreatedAtAction(nameof(GetById), new {id = created.Id}, created.ToResponse());
    }

    [HttpPut("{id:int}")]
    public ActionResult<UpdateProductDto> Update(int id, CreateProductDto dto)
    {
        var product = _service.GetById(id);

        if (product == null)
            return NotFound();
        
        return Ok(_service.Update(id, dto.ToEntity()));
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        if (!_service.Delete(id))
            return NotFound();
        
        return NoContent();
    }

    [HttpDelete]
    public IActionResult DeleteAll()
    {
        _service.DeleteAll();

        return NoContent();
    }
}
