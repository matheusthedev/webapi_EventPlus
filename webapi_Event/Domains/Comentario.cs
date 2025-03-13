using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventPLUS.Domains
{
    [Table("Comentario")]
    public class Comentario
    {

        [Key]

        public int IdComentario { get; set; }

        public int IdEvento { get; set; }
        [ForeignKey(nameof(IdEvento))]

        public int IdUsuario { get; set; }
        [ForeignKey(nameof(IdUsuario))]

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "Qual a descricao do evento e obrigatorio!")]

        public string? Descricao { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O nome do evento e obrigatorio!")]

        public string? NomeEvento { get; set; }

        public bool Exibir { get; set; } = true;


    }
}
