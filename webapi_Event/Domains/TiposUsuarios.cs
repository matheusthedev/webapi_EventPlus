using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Event_.Domains
{
    [Table("TiposUsuarios")]
    public class TiposUsuarios
    {

        [Key]
        public Guid IdTiposUsuarios { get; set; }

        [Column(TypeName = "VARCHAR(70)")]
        [Required(ErrorMessage = "O tipo de usuario é Obrigatório!")]
        public string? TituloTipoUsuario { get; set; }

        



    }
}
