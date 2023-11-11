using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_Taller64.Models
{
    public class CredencialesAcceso
    {
        [Required]
        public String NombreUsuario { get; set; }
        [Required]
        public String Password { get; set; }
        public String Cedula { get; set; }
        [ForeignKey("Cedula")]
        public virtual Usuario Usuario { get; set; }
    }
}
