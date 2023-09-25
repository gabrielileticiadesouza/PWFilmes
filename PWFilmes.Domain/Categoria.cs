using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWFilmes.Domain
{
    [Table("Categoria")]
   public class Categoria
    {
        [Key]
        [Required(ErrorMessage = "O código deve ser informado!")]
        public int Codigo { get; set; }

        [Required (ErrorMessage ="A descrição deve ser informada!")]
        [MaxLength (100, ErrorMessage = "A descrição deve conter no maximo 100 caracteres!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage ="A cor deve ser informada!")]
        [MaxLength (50, ErrorMessage ="A cor deve conter no máximo 50 caracteres!!")]
        public string Cor { get; set; }
    }
}
