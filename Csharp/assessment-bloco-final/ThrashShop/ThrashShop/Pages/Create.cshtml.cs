using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using ThrashShop.Models;
using ThrashShop.Services;

namespace ThrashShop.Pages;

    public class Create : PageModel
    {
        private readonly IToastNotification _notify;
        private ISkateService _service;
        
        public SelectList MarcaOptionsItems { get; set; }
        
        public Create(ISkateService skateService, IToastNotification notify)
        {
            _service = skateService;
            _notify = notify;
        }

        public void OnGet()
        {
            MarcaOptionsItems = new SelectList(_service.obterTodasAsMarcas(),
                nameof(Marca.MarcaId),
                nameof(Marca.Nome));
        }

        [BindProperty]
        public Skate Skate { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                _notify.AddErrorToastMessage("Erro ao criar um novo equipamento!");
                return Page();
            }

            _service.Incluir(Skate);
            _notify.AddSuccessToastMessage("Novo equipamento criado com sucesso!");

            return RedirectToPage("/Index");
        }
    }
