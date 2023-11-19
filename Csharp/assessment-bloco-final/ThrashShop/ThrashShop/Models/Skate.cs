using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThrashShop.Models;

[Table("TB_SKATE")]
public class Skate
{
    public int SkateId { get; set; }
    
    
    [Required(AllowEmptyStrings = false, ErrorMessage = "Campo nome é obrigatório.")]
    [StringLength(50, MinimumLength = 10, ErrorMessage = "Campo 'nome' deve conter entre 10 e 50 caractéres.")]
    public string Nome { get; set; }
    public string NomeSlug => Nome.ToLower().Replace(" ", "-");
    
    
    [Display(Name = "Descrição")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Campo descrição é obrigatório.")]
    [StringLength(300, MinimumLength = 20, ErrorMessage = "Campo 'descrição' deve conter entre 20 e 300 caractéres.")]
    public string Descricao { get; set; }
    
    
    [Display(Name = "Caminho da imagem")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Campo 'caminho da imagem' é obrigatório.")]
    public string ImagemUri { get; set; }
    
    
    [Display(Name = "Preço")]
    [DataType(DataType.Currency)]
    [Required(ErrorMessage = "Campo preço é obrigatório.")]
    public double Preco { get; set; }
    
    [Display(Name = "Entrega Rápida")]
    public bool EntregaExpressa { get; set; }

    public string EntregaExpressaFormatada => EntregaExpressa ? "Sim" : "Não";
    
    [Display(Name = "Disponível desde")]
    [DataType("month")]
    [DisplayFormat(DataFormatString = "{0:MMMM \\de yyyy}")]
    public DateTime DataCadastro { get; set; }
}