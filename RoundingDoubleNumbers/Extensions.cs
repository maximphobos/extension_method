namespace RoundingDoubleNumbers
{
    public static partial class Extensions
    {
        public static int Round(this double a)
        {
            return Convert.ToInt32(Math.Round(a, MidpointRounding.AwayFromZero));
        }
    }
}
