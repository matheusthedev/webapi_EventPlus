using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace Event_.Domains
{
    [Table("Usuarios")]
    [Index(nameof(Senha), IsUnique = true)]
    public class Usuarios
    {

        [Key]

        public Guid IdUsuario { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O nome e obrigatorio!")]

        public string? Nome { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O email e obrigatorio!")]

        public string? Email { get; set; }

        [Column(TypeName = "VARCHAR(60)")]
        [Required(ErrorMessage = "A senha e obrigatoria!")]

        public string? Senha { get; set; }

        public Guid IdTiposUsuarios { get; set; }

        [ForeignKey("IdTiposUsuarios")]
        public TiposUsuarios? TiposUsuarios { get; set; }
    }
}
