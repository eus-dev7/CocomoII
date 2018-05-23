using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace CocomoII
{
    class Validacion
    {
        public void SoloLetras(KeyPressEventArgs e)
        {
            char letras;
            letras = e.KeyChar;
            if (char.IsLetter(letras))
            {
                e.Handled = false;
            }
            else if (char.IsControl(letras))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }


        }

        public void SoloNumeros(KeyPressEventArgs e)
        {
            char letras;
            letras = e.KeyChar;
            if (char.IsDigit(letras))
            {
                e.Handled = false;
            }
            else if (char.IsControl(letras))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public Int32 calculo_smc(int cantidadSimple, int pesoSimple, int cantidaMedia, int pesoMedia, int cantidadCompleja, int pesoCompleja)
        {
            try
            {
                int r = 0;
                int s = 0;
                int m = 0;
                int c = 0;
                s = cantidadSimple * pesoSimple;
                m = cantidaMedia * pesoMedia;
                c = cantidadCompleja * pesoCompleja;
                r = s + m + c;
                return r;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
