namespace StudentMeter
{
    internal static class InputHandler
    {
        /// <summary>
        /// Checks the input is number, control or white space.
        /// </summary>
        public static bool IsLetter(KeyPressEventArgs e)
        {
            return !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        /// <summary>
        /// Checks the input is number or control.
        /// </summary>
        public static bool IsNumber(KeyPressEventArgs e)
        {
            return !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}