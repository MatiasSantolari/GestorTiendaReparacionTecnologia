using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class ValidacionesVista
    {
        public static bool EsTextoValido(string texto)
        {
            return !string.IsNullOrWhiteSpace(texto);
        }

        public static bool EsEmailValido(string email)
        {
            return email.Contains("@") && email.Contains("."); //se puede mejorar, pero otro día con mas calmita
        }

        public static bool EsTelefonoValido(string telefono)
        {
            return telefono.All(char.IsDigit) && telefono.Length >= 7;
        }

        public static bool EsPasswordFuerte(string password)
        {
            return password.Length >= 6; // tambien se puede mejorar, meterle un par de vitaminas
        }

        public static bool ComboBoxSeleccionado(ComboBox cb)
        {
            return cb.SelectedItem != null;
        }
    }
}
