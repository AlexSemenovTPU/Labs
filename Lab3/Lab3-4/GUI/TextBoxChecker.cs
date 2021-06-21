using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI
{
    /// <summary>
    /// Класс для обработки ввода данных
    /// на формах
    /// </summary>
    public static class TextBoxChecker
    {
        /// <summary>
        /// Обработка ввода данных на формах
        /// </summary>
        /// <param name="pattern">Паттерн</param>
        /// <param name="e">Объект события</param>
        public static void TextBoxKeyPress (string pattern, KeyPressEventArgs e)
        {
            var letterRegex = new Regex(pattern);

            if (!letterRegex.IsMatch(e.KeyChar.ToString())
                    || e.KeyChar == (char)Keys.Back) return;

            e.Handled = true;
        }
    }
}
