using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI
{
    /// <summary>
    /// Класс для обработки ввода в TextBox
    /// </summary>
    public static class CheckBox
    {
        /// <summary>
        /// Обработка ввода в TextBox
        /// </summary>
        /// <param name="pattern">Паттерн</param>
        /// <param name="e">Объект события</param>
        public static void CheckBox_KeyPress (string pattern, KeyPressEventArgs e)
        {
            Regex letterRegex = new Regex(pattern);

            if (!letterRegex.IsMatch(e.KeyChar.ToString())
                    || e.KeyChar == (char)Keys.Back) return;

            e.Handled = true;
        }
    }
}
