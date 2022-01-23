
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EjercicioAlkemy2.Models
    
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(12,ErrorMessage ="NickName invalido. Debe tener entre 6 y 12 caracteres."),MinLength(6, ErrorMessage = "NickName invalido. Debe tener entre 6 y 12 caracteres.")]
        public string NickName { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        
        public virtual ICollection<Post> Posts { get; set; }
    }
}
