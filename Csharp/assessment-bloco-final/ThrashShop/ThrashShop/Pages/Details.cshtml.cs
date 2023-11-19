using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ThrashShop.Models;
using ThrashShop.Services;

namespace ThrashShop.Pages;

public class Details : PageModel
{
    private ISkateService _service;

    public Details(ISkateService skateService)
    {
        _service = skateService;
    }
    public Skate Skate { get; private set; }
    
    public IActionResult OnGet(int id)
    {
        var servico = new SkateService();
        Skate = _service.Obter(id);

        if (Skate == null)
        {
            return NotFound();
        }

        return Page();
    }
}