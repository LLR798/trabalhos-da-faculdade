using EasyReserve.API.Integration.Response;
using EasyReserve.API.Services.ViaCepService;
using Microsoft.AspNetCore.Mvc;

namespace EasyReserve.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CepController : ControllerBase
{
    private readonly IViaCepService _viaCepService;

    public CepController(IViaCepService viaCepService)
    {
        _viaCepService = viaCepService;
    }
    
    [HttpGet("{cep}")]
    public async Task<ActionResult<ViaCepResponse>> GetDataAddress(string cep)
    {
        var responseData = await _viaCepService.GetDataViaCep(cep);

        if (responseData == null)
        {
            return BadRequest("CEP não encontrado!");
        }
        
        return Ok(responseData);
    }
}