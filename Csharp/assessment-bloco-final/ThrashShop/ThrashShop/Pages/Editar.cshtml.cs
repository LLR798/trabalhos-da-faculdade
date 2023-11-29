using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using ThrashShop.Models;
using ThrashShop.Services;

namespace ThrashShop.Pages;

public class Editar : PageModel
{
    private ISkateService _service;

    public SelectList MarcaOptionsItems { get; set; }

    private readonly IToastNotification _notify;

    public Editar(ISkateService skateService, IToastNotification notify)
    {
        _service = skateService;
        _notify = notify;
    }

    [BindProperty] public Skate Skate { get; set; }

    public void OnGet(int id)
    {
        Skate = _service.Obter(id);
        MarcaOptionsItems = new SelectList(_service.obterTodasAsMarcas(),
            nameof(Marca.MarcaId),
            nameof(Marca.Nome));
    }

    public IActionResult OnPost()
    {
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