using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using ThrashShop.Models;
using ThrashShop.Services;

namespace ThrashShop.Pages;

    [Authorize]
    public class Create : PageModel
    {
        private readonly IToastNotification _notify;
        private ISkateService _service;
        
        public SelectList MarcaOptionsItems { get; set; }
        public SelectList CategoriaOptionsItems { get; set; }
        
        public Create(ISkateService skateService, IToastNotification notify)
        {
            _service = skateService;
            _notify = notify;
        }

        public void OnGet()
        {
            MarcaOptionsItems = new SelectList(_service.ObterTodasAsMarcas(),
                nameof(Marca.MarcaId),
                nameof(Marca.Nome));    
            
            CategoriaOptionsItems = new SelectList(_service.ObterTodasAsCategorias(),
                nameof(Categoria.CategoriaId),
                nameof(Categoria.Descricao));
        }

        [BindProperty]
        public Skate Skate { get; set; } 
        
        [BindProperty]
        public IList<int> CategoriaIds { get; set; }

        public IActionResult OnPost()
        {
            Skate.Categorias = _service.ObterTodasAsCategorias()
                .Where(item => CategoriaIds.Contains(item.CategoriaId))
                .ToList();
            
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
