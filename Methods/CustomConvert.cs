namespace DersTakip
{
    public static class CustomConvert
    {
        public static float ToFloat(string input)
        {
            return (float)Convert.ToDouble(input);
        }
    }
}