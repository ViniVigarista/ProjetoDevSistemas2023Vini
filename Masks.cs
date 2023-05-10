using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDevSistemas2023Vini
{
    internal class Masks
    {
        static string valor;
        static int lastDigit;
        static string lastDigitString;
        private static void Aplica_KeyPress_Reais(object sender, KeyPressEventArgs e)
        {
            TextBoxBase txt = (TextBoxBase)sender;
            int maxLength = txt.MaxLength;
            int currentLength = txt.Text.Length;
            lastDigit = Convert.ToInt16(e.KeyChar.ToString());
            lastDigitString = lastDigit.ToString();
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(","));
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (currentLength >= maxLength && e.KeyChar != Convert.ToChar(Keys.Back))
            {

                MessageBox.Show("Quantidade máxima de caracteres atingida", "Valor máximo excedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                string valorString = valor.ToString();
                valorString = valorString.Substring(1) + lastDigitString;
                txt.Text = Properties.Resources.moeda + valorString;
                e.Handled = true;

            }
        }
        private static void Aplica_Leave_Reais(object sender, EventArgs e)
        {
            TextBoxBase txt = (TextBoxBase)sender;
            valor = txt.Text.Replace("R$", "");
            txt.Text = string.Format("{0:C}", Convert.ToDouble(valor));
        }
        private static void Aplica_KeyUp_Reais(object sender, KeyEventArgs e)
        {
            TextBoxBase txt = (TextBoxBase)sender;

            valor = txt.Text.Replace("R$", "").Replace(",", "").Replace(" ", "");
            if (valor.Length == 0)
            {
                txt.Text = "0,00" + valor;
            }
            else if (valor.Length == 1)
            {
                txt.Text = "0,0" + valor;
            }
            else if (valor.Length == 2)
            {
                txt.Text = "0," + valor;
            }
            else if (valor.Length >= 3)
            {
                if (txt.Text.StartsWith("0,"))
                {
                    txt.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                }
                else if (txt.Text.Contains("00,"))
                {
                    txt.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                }
                else
                {
                    txt.Text = valor.Insert(valor.Length - 2, ",");
                }
            }
            valor = txt.Text;
            txt.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            txt.Select(txt.Text.Length, 0);
        }
        public static void AplicaMascaraMoeda2(TextBoxBase txt)
        {
            txt.KeyPress += Aplica_KeyPress_Reais;
            txt.Leave += Aplica_Leave_Reais;
            txt.KeyUp += Aplica_KeyUp_Reais;
        }
    }
}
