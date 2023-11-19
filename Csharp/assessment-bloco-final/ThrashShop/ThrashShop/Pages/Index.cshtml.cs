using Microsoft.AspNetCore.Mvc.RazorPages;
using ThrashShop.Models;
using ThrashShop.Services;

namespace ThrashShop.Pages;

public class IndexModel : PageModel
{
    private ISkateService _service;

    public IndexModel(ISkateService skateService)
    {
        _service = skateService;
    }
    public IList<Skate> ListaDeSkates { get; private set; }

    public void OnGet()
    {
        // ViewData["Title"] = "Home Page";

        ListaDeSkates = _service.ObterTodos();
    }
}