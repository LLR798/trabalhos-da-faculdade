using System.ComponentModel.DataAnnotations;

namespace EasyReserve.API.DTOs;

public class ClientDTO
{
    [Key]
    public int ClientId { get; set; }
    
    [Required]
    [MaxLength(255, ErrorMessage = "O nome não pode ter mais de 255 caracteres.")]
    public string Name { get; set; }
    
    [Required]
    [MaxLength(255, ErrorMessage = "O e-mail não pode ter mais de 255 caracteres.")]
    public string Email { get; set; }
    
    [Required]
    [MaxLength(14, ErrorMessage = "O telefone do cliente precisa ter 14 caracteres.")]
    public string Phone { get; set; }
}