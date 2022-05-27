using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysPatrimonio.Models
{
    [Table("Usuario", Schema = "public")]
    public class DbUsuario
    {
        [Key]
        public int id { get; set; }
        [Display(Name ="Nome")]
        public string? nome { get; set; }
        [Display(Name ="Login")]
        public string? login { get; set; }
        [Display(Name ="Senha")]
        public string? senha { get; set; }
        [Display(Name ="Ativo S/N?")]
        public string? status { get; set; }
    }
}
