using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    public class PrecioTareaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PrecioTareaID { get; set; }
        public DateTime FechaVigencia { get; set; }
        public float Monto { get; set; }
        public int TareaID { get; set; }
        [ForeignKey("TareaID")]
        // uno a muchos --> un preciotarea pertenece a una tarea, una tarea tiene muchos preciostarea
        public virtual TareaModel Tarea { get; set; }
    }
}
