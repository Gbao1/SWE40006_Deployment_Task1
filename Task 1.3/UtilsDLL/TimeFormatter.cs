using System.Globalization;

namespace UtilsDLL
{
    /// <summary>Formatting helpers for time and labels.</summary>
    public static class TimeFormatter
    {
        public static string PrefixLabel(string time)
        {
            return string.Format(CultureInfo.InvariantCulture, "Elapsed: {0}", time);
        }
    }
}
