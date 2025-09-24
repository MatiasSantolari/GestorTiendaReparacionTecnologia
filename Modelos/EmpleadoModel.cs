using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class EmpleadoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpleadoID { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Password {  get; set; }
        public string Rol {  get; set; }
        // muchos a muchos --> un epleado tiene muchos trabajos, un trabajo tiene muchos empleados
        public virtual ICollection<TrabajoModel> Trabajos { get; set; } = new List<TrabajoModel>();
        // muchos a muchos --> un empleado hace muchas tareas, una tarea se hace por muchos empleados
        public virtual ICollection<TareaModel> Tareas { get; set; } = new List<TareaModel>();
    }
}
