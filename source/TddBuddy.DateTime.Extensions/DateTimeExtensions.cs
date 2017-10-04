namespace TddBuddy.DateTime.Extensions
{
    public static class DateTimeExtensions
    {
        public static string ConvertTo24HourFormatWithSeconds(this System.DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
