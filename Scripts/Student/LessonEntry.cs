namespace StudentMeter
{
    public class LessonEntry
    {
        public LessonEntry(string date, string startTime, string finishTime, string lessonCost)
        {
            Date = date;
            StartTime = startTime;
            FinishTime = finishTime;
            LessonCost = lessonCost;
        }

        public string Date { get; set; }
        public string StartTime { get; set; }
        public string FinishTime { get; set; }
        public string LessonCost { get; set; }
    }
}