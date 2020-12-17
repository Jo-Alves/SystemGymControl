using System;
using System.Windows.Forms;

namespace SystemGymControl
{
    static class FormatTextBox
    {
        public static string FormatValueDecimal(string valueDecimal)
        {
            if (!string.IsNullOrEmpty(valueDecimal))
            {
                valueDecimal = Convert.ToDecimal(valueDecimal).ToString("0.00");
            }

            return valueDecimal;
        }

        public static void HandleFormatTextBox(Control textBox, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textBox.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }
    }
}
