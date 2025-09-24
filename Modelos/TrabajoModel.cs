using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class TrabajoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TrabajoID {  get; set; }
        public string NombreDispositivo { get; set; }
        public string DescripcionProblema { get; set; }
        public string Estado {  get; set; }
        public DateTime FechaSolicitud { get; set; }
        public int ClienteID { get; set; }
        [ForeignKey("ClienteID")]
        // uno a muchos --> un trabajo tiene solo un cliente, un cliente muchos trabajos
        public virtual ClienteModel Cliente { get; set; }

        // muchos a muchos --> un trabajo tiene muchas tareas y una tarea pertenece a muchos trabajos
        public virtual ICollection<TareaModel> Tareas { get; set; } = new List<TareaModel>();
        // muchos a muchos --> un trabajo tiene muchos empleados, un empleado pertenece a muchos trabajos
        public virtual ICollection<EmpleadoModel> Empleados { get; set; } = new List<EmpleadoModel>();

    }
}
