namespace StudentMeter
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

        public static float CalculateHours(string startTime, string finishTime)
        {
            //Splits texts of times.
            string[] start = startTime.Split(':');
            string[] finish = finishTime.Split(':');

            return CalculateHours(start[0], start[1], finish[0], finish[1]);
        }

        public static float CalculateHours(string startHours, string startMinute, string finishHours, string finishMinutes)
        {
            //Start
            int _startHours = Convert.ToInt16(startHours);
            int _startMinutes = Convert.ToInt16(startMinute);

            //Finish
            int _finishHours = Convert.ToInt16(finishHours);
            int _finishMinutes = Convert.ToInt16(finishMinutes);

            //Calculates the difference of minutes and hours.
            int minutes = _finishMinutes - _startMinutes;
            int hours = _finishHours - _startHours;

            return CalculateDifferenceOfTime(minutes, hours);
        }

        public static string IsEmpty(string text)
        {
            return string.IsNullOrEmpty(text) ? "00" : text;
        }

        private static float CalculateDifferenceOfTime(int minutes, int hours)
        {
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

            return hours + ((float)minutes / 60);
        }
    }
}