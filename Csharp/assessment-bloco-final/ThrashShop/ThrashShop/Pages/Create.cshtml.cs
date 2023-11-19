using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NToastNotify;
using ThrashShop.Models;
using ThrashShop.Services;

namespace ThrashShop.Pages;

    public class Create : PageModel
    {
        private readonly IToastNotification _notify;
        private ISkateService _service;
        
        public Create(ISkateService skateService, IToastNotification notify)
        {
            _service = skateService;
            _notify = notify;
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
