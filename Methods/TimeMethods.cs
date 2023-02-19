namespace DersTakip
{
    public static class TimeMethods
    {
        public static string[] GetCurrentTimeAsText()
        {
            string[] result = new string[2];

            //Gets current time.
            DateTime currentTime = DateTime.Now;

            //Gets minute's value as text.
            string minute = currentTime.Minute.ToString();

            //To ensure the layout of the writing.
            if (currentTime.Minute < 10)
            {
                minute = "0" + currentTime.Minute.ToString();
            }

            result[0] = currentTime.Hour.ToString();
            result[1] = minute;

            //Returns hour and minute
            return result;
        }

        public static float CalculateHours(string startHours, string startMinute, string finishHours, string finishMinutes)
        {
            //Calculates the difference of minutes and hours.
            float minutes = CustomConvert.ToFloat(finishMinutes) - CustomConvert.ToFloat(startMinute);
            float hours = CustomConvert.ToFloat(finishHours) - CustomConvert.ToFloat(startHours);

            //Bug guarding.
            if (minutes < 0)
            {
                minutes += 60;
                hours--;
            }

            //Bug guarding.
            if (hours < 0)
            {
                hours += 24;
            }

            //Rounds minutes.
            if (minutes < 15)
            {
                minutes = 0;
            }
            else if (minutes > 45)
            {
                minutes = 60;
            }
            else
            {
                minutes = 30;
            }

            return hours + (minutes / 60);
        }

        public static string IsEmpty(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                text = "00";
            }

            return text;
        }
    }
}