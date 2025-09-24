using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    internal class ValidacionesNegocio
    {
        public static Boolean ValidarCoincidenciaPasswords(string pass, string repPass)
        {
            if (pass != repPass) return false;
            else return true;
        }
    }
}
