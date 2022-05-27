using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysPatrimonio.Models
{
    [Table("Categoria", Schema = "public")]
    public class DbCategoria
    {
        [Key]
        public int id { get; set; }
        [Display(Name ="Descrição Categoria")]
        public string? descricaocategoria { get; set; }

    }
}
