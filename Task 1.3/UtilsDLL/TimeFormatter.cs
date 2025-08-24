using System.Globalization;

namespace UtilsDLL
{
    public static class TimeFormatter
    {
        public static string PrefixLabel(string time)
        {
            return string.Format(CultureInfo.InvariantCulture, "Elapsed: {0}", time);
        }
    }
}
