using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using ThrashShop.Models;
using ThrashShop.Services;

namespace ThrashShop.Pages;

[Authorize]
public class Editar : PageModel
{
    private ISkateService _service;

    public SelectList MarcaOptionsItems { get; set; }
    public SelectList CategoriaOptionsItems { get; set; }

    private readonly IToastNotification _notify;

    public Editar(ISkateService skateService, IToastNotification notify)
    {
        _service = skateService;
        _notify = notify;
    }

    [BindProperty] public Skate Skate { get; set; }
    
    [BindProperty]
    public IList<int> CategoriaIds { get; set; }

    public void OnGet(int id)
    {
        Skate = _service.Obter(id);

        CategoriaIds = Skate.Categorias.Select(item => item.CategoriaId).ToList();
        
        MarcaOptionsItems = new SelectList(_service.ObterTodasAsMarcas(),
            nameof(Marca.MarcaId),
            nameof(Marca.Nome)); 
        
        CategoriaOptionsItems = new SelectList(_service.ObterTodasAsCategorias(),
            nameof(Categoria.CategoriaId),
            nameof(Categoria.Descricao));
    }

    public IActionResult OnPost()
    {
        Skate.Categorias = _service.ObterTodasAsCategorias()
            .Where(item => CategoriaIds.Contains(item.CategoriaId))
            .ToList();
        
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _service.Alterar(Skate);
        _notify.AddSuccessToastMessage("Equipamento alterado com sucesso!");

        return RedirectToPage("/Index");
    }

    public IActionResult OnPostDelete()
    {
        _service.Excluir(Skate.SkateId);
        _notify.AddAlertToastMessage("Equipamento excluido com sucesso!");

        return RedirectToPage("/Index");
    }
}