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
        public static void CheckBoxKeyPress (string pattern, KeyPressEventArgs e)
        {
            var letterRegex = new Regex(pattern);

            if (!letterRegex.IsMatch(e.KeyChar.ToString())
                    || e.KeyChar == (char)Keys.Back) return;

            e.Handled = true;
        }
    }
}
