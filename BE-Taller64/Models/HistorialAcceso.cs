using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_Taller64.Models
{
    public class HistorialAcceso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public String Cedula { get; set; }
        [ForeignKey("Cedula")]
        public virtual Usuario Usuario { get; set; }
    }
}


