using SportGym.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportGym.GUI
{
    public class Support
    {
        private static Support instance = new Support();
        private DBHelper helper = DBHelper.getDBHelper();

        public static Support GetSupport()
        {
            if (instance == null)
                instance = new Support();
            return instance;
        }

        public void soloLetrasNumeros(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = true;
            else if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else if (char.IsLetter(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
        public void soloLetrasNumerosConEspacio(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else if (char.IsLetter(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
        public void soloLetras(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = true;
            else if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else if (char.IsLetter(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
        public void soloNumeros(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = true;
            else if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
            else if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = true;
        }
        public void noEspaciosBlancos(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (char.IsSymbol(e.KeyChar))
                e.Handled = false;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = true;
            else if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else if (char.IsLetter(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }


        public void noSimbolos(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else if (char.IsLetter(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
        public void soloLetrasNumerosConAdvertencia(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsSymbol(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        if (char.IsSeparator(e.KeyChar))
                        {
                            e.Handled = true;
                            MessageBox.Show("No se permiten espacios en blanco", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (char.IsWhiteSpace(e.KeyChar))
                            {
                                e.Handled = false;
                            }
                            else
                            {
                                if (char.IsLetter(e.KeyChar))
                                {
                                    e.Handled = false;
                                }
                                else
                                {
                                    if (char.IsLetter(e.KeyChar))
                                    {
                                        e.Handled = false;
                                    }
                                    else
                                    {
                                        e.Handled = true;
                                        MessageBox.Show("Solo letras o numeros", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }

        public void soloLetrasConAdvertencia(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten numeros", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsSymbol(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        if (char.IsSeparator(e.KeyChar))
                        {
                            e.Handled = true;
                            MessageBox.Show("No se permiten espacios en blanco", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (char.IsWhiteSpace(e.KeyChar))
                            {
                                e.Handled = false;
                            }
                            else
                            {
                                if (char.IsLetter(e.KeyChar))
                                {
                                    e.Handled = false;
                                }
                                else
                                {
                                    if (char.IsLetter(e.KeyChar))
                                    {
                                        e.Handled = false;
                                    }
                                    else
                                    {
                                        e.Handled = true;
                                        MessageBox.Show("Solo letras o numeros", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }
        public void soloNumerosConAdvertencia(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsSymbol(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        if (char.IsSeparator(e.KeyChar))
                        {
                            e.Handled = true;
                            MessageBox.Show("No se permiten espacios en blanco", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (char.IsWhiteSpace(e.KeyChar))
                            {
                                e.Handled = false;
                            }
                            else
                            {
                                if (char.IsLetter(e.KeyChar))
                                {
                                    e.Handled = true;
                                    MessageBox.Show("Solo numeros", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    if (char.IsLetter(e.KeyChar))
                                    {
                                        e.Handled = true;
                                    }
                                    else
                                    {
                                        e.Handled = false;
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }
        public void soloLetrasSiEspacioConAdvertencia(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten numeros", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsSymbol(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        if (char.IsSeparator(e.KeyChar))
                        {
                            e.Handled = false;
                        }
                        else
                        {
                            if (char.IsWhiteSpace(e.KeyChar))
                            {
                                e.Handled = false;
                            }
                            else
                            {
                                if (char.IsLetter(e.KeyChar))
                                {
                                    e.Handled = false;
                                }
                                else
                                {
                                    if (char.IsLetter(e.KeyChar))
                                    {
                                        e.Handled = false;
                                    }
                                    else
                                    {
                                        e.Handled = true;
                                        MessageBox.Show("Solo letras", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }
        public void noEspaciosBlancosConAdvertencia(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsSymbol(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        if (char.IsSeparator(e.KeyChar))
                        {
                            e.Handled = true;
                            MessageBox.Show("No se permiten espacios en blanco", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (char.IsWhiteSpace(e.KeyChar))
                            {
                                e.Handled = false;
                            }
                            else
                            {
                                if (char.IsLetter(e.KeyChar))
                                {
                                    e.Handled = false;
                                }
                                else
                                {
                                    if (char.IsLetter(e.KeyChar))
                                    {
                                        e.Handled = false;
                                    }
                                    else
                                    {
                                        e.Handled = false;
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }
        public void noSimbolosConAdvertencia(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsSymbol(e.KeyChar))
                    {
                        e.Handled = true;
                        MessageBox.Show("No se permiten caracteres especiales", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (char.IsSeparator(e.KeyChar))
                        {
                            e.Handled = false;
                        }
                        else
                        {
                            if (char.IsWhiteSpace(e.KeyChar))
                            {
                                e.Handled = false;
                            }
                            else
                            {
                                if (char.IsLetter(e.KeyChar))
                                {
                                    e.Handled = false;
                                }
                                else
                                {
                                    if (char.IsLetter(e.KeyChar))
                                    {
                                        e.Handled = false;
                                    }
                                    else
                                    {
                                        e.Handled = false;
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }
        public void cargarCombo(ComboBox combo, string tabla, string value, string display)
        {
            // metodo para cualquier combo donde pasa el combo, la tabla, el id y el campo descripcion.
            combo.DataSource = DBHelper.getDBHelper().ConsultaSQL(tabla); //
            combo.DisplayMember = display; //nombre del campo que lista el combo
            combo.ValueMember = value; // nombre del campo Id que se guarda en cada ítems de la lista
        }
       
    }
}

