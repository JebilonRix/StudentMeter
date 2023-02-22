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
            string hour = currentTime.Hour.ToString();

            //Fix texts' format.
            minute = FixFormatting(minute);
            hour = FixFormatting(hour);

            result[0] = hour;
            result[1] = minute;

            //Returns hour and minute
            return result;
        }

        /// <summary>
        /// Splits string with ":", index 0 is hour, index 1 is minute.
        /// </summary>
        public static string[] SplitTime(string time)
        {
            return time.Split(':');
        }

        public static float CalculateHoursUnsplitted(string startTime, string finishTime)
        {
            //Splits texts of times.
            string[] start = SplitTime(startTime);
            string[] finish = SplitTime(finishTime);

            return CalculateHoursSplitted(start[0], start[1], finish[0], finish[1]);
        }

        public static float CalculateHoursSplitted(string startHours, string startMinute, string finishHours, string finishMinutes)
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

        /// <summary>
        /// If text boxes of time are empty, adds 00 to them
        /// </summary>
        public static string FixFormatting(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                text = "00";
            }
            else if (Convert.ToInt16(text) < 10)
            {
                text = "0" + text;
            }

            return text;
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
            if (minutes < 20)
            {
                minutes = 0;
            }
            else if (minutes >= 40)
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