using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysPatrimonio.Models
{
    [Table("Patrimonio", Schema = "public")]
    public class DbPatrimonio
    {
        [Key]
        public int id { get; set; }
        [Display(Name ="Nº Etiqueta")]
        public string? numeroetiqueta { get; set; }
        [Display(Name ="Nome")]
        public string? nomepatrimonio { get; set; }
        [Display(Name ="Descrição")]
        public string? descricaopatrimonio { get; set; }
        [Display(Name ="Valor")]
        public string? valorpatrimonio { get; set; }
        public int idcategoria { get; set; }
        public int idlocal { get; set; }
        public int iddepartamento { get; set; }
        public string? marcamodelo { get; set; }
        public DateTime dataaquisicao { get; set; }
        public DateTime databaixa { get; set; }
    }
}
