using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysPatrimonio.Models
{
    [Table("Local", Schema = "public")]
    public class DbLocal
    {
        [Key]
        public int id { get; set; }
        [Display(Name ="Local")]
        public string? nomelocal { get; set; }
        [Display(Name ="Descrição Local")]
        public string? descicaolocal { get; set; }

    }
}
