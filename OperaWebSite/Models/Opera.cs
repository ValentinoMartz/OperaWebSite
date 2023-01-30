using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OperaWebSite.Validations;


namespace OperaWebSite.Models
{
    public class Opera
    {
        public int OperaId { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]//view/EF
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]//view
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]//view/EF
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]//view
        public string Composer{ get; set; }

        [CheckValidYear]
        public int Year{ get; set; }
    }
}
