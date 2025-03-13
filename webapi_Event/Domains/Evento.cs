using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Event_.Domains
{

    [Table("Evento")]
    public class Evento
    {

        [Key]
        public Guid IdEvento { get; set; }

        public Guid IdTipoEvento { get; set; }
        [ForeignKey(nameof(IdTipoEvento))]

        public Guid IdInstituicoes { get; set; }
        [ForeignKey(nameof(IdInstituicoes))]

        public Guid PresencaEventos { get; set; }


        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O nome do evento e obrigatorio!")]

        public string? NomeEvento { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "A data do evento e obrigatorio!")]

        public DateTime DataEvento { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Qual a descricao do evento, e obrigatorio!")]

        public string? Descricao { get; set; }









    }
}






