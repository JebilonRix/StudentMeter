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
    }
}
