namespace StudentMeter
{
    public static class CustomConvert
    {
        public static float ToFloat(string input)
        {
            double.TryParse(input, out double result);
            return (float)result;
        }
    }
}