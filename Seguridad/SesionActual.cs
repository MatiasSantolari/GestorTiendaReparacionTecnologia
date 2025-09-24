using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Seguridad
{
    public static class SesionActual
    {
        public static EmpleadoModel Empleado { get; private set; }

        public static void IniciarSesion(EmpleadoModel empleado)
        {
            Empleado = empleado;
        }

        public static void CerrarSesion()
        {
            Empleado = null;
        }

        public static bool EsAdmin => Empleado != null && Empleado.Rol == "Admin";
        public static bool EsTecnico => Empleado != null && Empleado.Rol == "Tecnico";
    }

}
