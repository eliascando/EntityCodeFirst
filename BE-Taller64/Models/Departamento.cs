using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_Taller64.Models
{
    public class Departamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartamentoId { get; set; }
        public String NombreDepartamento { get; set; }
        public String Descripcion { get; set; }
        public Boolean EstadoDepartamento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
