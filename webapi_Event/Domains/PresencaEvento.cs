using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Event_.Domains
{
    [Table("PresencaEventos")]
    public class PresencaEventos
    {

        [Key]

        public Guid IdPresencaEvento { get; set; }

        public Guid IdUsuario { get; set; }
        [ForeignKey(nameof(IdUsuario))]

        public Guid IdEvento { get; set; }
        [ForeignKey(nameof(IdEvento))]


        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O Evento ainda esta desponivel obrigatorio!")]

        public string? Situacao { get; set; }

    }
}
