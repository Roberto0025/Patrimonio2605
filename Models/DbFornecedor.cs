using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysPatrimonio.Models
{
    [Table("fornecedor", Schema = "public")]
    public class DbFornecedor
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Fornecedor")]
        public string? nomefornecedor { get; set; }
        [Display(Name ="Endereço")]
        public string? endereco { get; set; }
        [Display(Name = "Telefone")]
        public string? fone { get; set; }

    }
}
