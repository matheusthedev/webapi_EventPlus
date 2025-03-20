using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Event_.Domains
{
    [Table("TipoEvento")]
    public class TipoEvento
    {

        [Key]
        public Guid IdTipoEvento { get; set; }

        [Column(TypeName = "VARCHAR(70)")]
        [Required(ErrorMessage = "O tipo de evento é Obrigatório!")]
        public string? TituloTipoEvento { get; set; }


    }
}
