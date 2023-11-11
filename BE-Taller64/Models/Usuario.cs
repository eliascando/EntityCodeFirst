using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_Taller64.Models
{
    public class Usuario
    {
        [Required]
        [Key]
        public String Cedula { get; set; }
        [Required]
        public String Nombres { get; set; }
        [Required]
        public String Apellidos { get; set; }
        [Required]
        public Boolean EstadoUsuario { get; set; }
        [Required]
        public DateTime FechaRegistro { get; set; }
        public int DepartamentoId { get; set; }
        [ForeignKey("DepartamentoId")]
        public virtual Departamento Departamento { get; set; }
    }
}


