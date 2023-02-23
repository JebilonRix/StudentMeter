namespace StudentMeter
{
    public static class FormMethods
    {
        public static void SetTimeToBoxes(TextBox hourTextBox, TextBox minuteTextBox)
        {
            //Gets results of time.
            string[] result = TimeMethods.GetCurrentTimeAsText();

            //Sets currentName time to the text box.
            hourTextBox.Text = result[0];
            minuteTextBox.Text = result[1];
        }

        /// <summary>
        /// Checks the input is number or control.
        /// </summary>
        public static bool InputCheckNumber(KeyPressEventArgs e)
        {
            return !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        /// <summary>
        /// Checks the input is number, control or white space.
        /// </summary>
        public static bool InputCheckName(KeyPressEventArgs e)
        {
            return !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }
    }
}