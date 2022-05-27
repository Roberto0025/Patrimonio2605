using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysPatrimonio.Models
{
    [Table("Departamento", Schema = "public")]
    public class DbDepartamento
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Nome")]
        public string? nomedepartamento { get; set; }
        [Display(Name ="Descrição")]
        public string? descricacaodepartamento { get; set; }
        [Display(Name ="IdLocal")]
        public int idlocal { get; set; }

    }
}
