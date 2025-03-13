using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Event_.Domains
{
    [Table("Instituicoes")]
    [Index(nameof(CNPJ), IsUnique = true)]
    public class Instituicoes
    {

        [Key]
        public Guid IdInstituicoes { get; set; }


        [Column(TypeName = "VARCHAR(14)")]
        [Required(ErrorMessage = "O nome fantasia e obrigatorio!")]
        [StringLength(14)]

        public string? NomeFantasia { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O endereco e obrigatorio!")]

        public string? Endereco { get; set; }

        [Column(TypeName = "VARCHAR(60)")]
        [Required(ErrorMessage = "O CNPJ e obrigatoria!")]

        public int CNPJ { get; set; }

    }
}
