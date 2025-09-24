using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Modelos
{
    public class TareaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TareaID { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        // uno a muchos --> una tarea tiene muchos preciostarea, un preciotarea pertenece a una tarea
        public virtual ICollection<PrecioTareaModel> PreciosTarea { get; set; }
        //muchos a muchos --> una tarea pertenece a muchos trabajos y un trabajo tiene muchas tareas
        public virtual ICollection<TrabajoModel> Trabajos { get; set; } = new List<TrabajoModel>();
        // muchos a muchos --> una tarea puede hacerse por muchos empleados, un empleado hace muchas tareas
        public virtual ICollection<EmpleadoModel> Empleados { get; set; } = new List<EmpleadoModel>();
    }
}
