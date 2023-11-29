using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ThrashShop.Models;
using ThrashShop.Services;
using ThrashShop.Services.Memory;

namespace ThrashShop.Pages;

public class Details : PageModel
{
    private ISkateService _service;

    public Details(ISkateService skateService)
    {
        _service = skateService;
    }
    public Skate Skate { get; private set; }
    public Marca Marca { get; private set; }
    
    public IActionResult OnGet(int id)
    {
        var servico = new SkateService();
        
        Skate = _service.Obter(id);
        Marca = _service.obterTodasAsMarcas().SingleOrDefault(item => item.MarcaId == Skate.MarcaId);

        if (Skate == null)
        {
            return NotFound();
        }

        return Page();
    }
}