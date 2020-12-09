using System;
using System.Collections.Generic;
using System.Globalization;

namespace Mersy.Common.Helpers
{
    public static class Dates
    {
        public static IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        { // foreach (DateTime day in Dates.EachDay(df, dt))
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }
        public static int GetValueDayOfTheWeek(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Friday:
                    return 5;
                case DayOfWeek.Monday:
                    return 1;
                case DayOfWeek.Saturday:
                    return 6;
                case DayOfWeek.Sunday:
                    return 7;
                case DayOfWeek.Thursday:
                    return 4;
                case DayOfWeek.Tuesday:
                    return 2;
                case DayOfWeek.Wednesday:
                    return 3;
                default:
                    return 0;
            }
        }

        public static DateTime FormatedDateDo(string date)
        {
            if (string.IsNullOrEmpty(date))
            {
                return DateTime.Today;
            }

            try
            {
                date = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString();
                return Convert.ToDateTime(date);
            }
            catch (Exception)
            {
                date = DateTime.Today.Day.ToString("00") + "/" + DateTime.Today.Month.ToString("00") + "/" + DateTime.Today.Year.ToString();
                return Convert.ToDateTime(date);
            }
        }

        public static DateTime FormatedDate(string date)
        {
            if (string.IsNullOrEmpty(date))
            {
                return DateTime.Today;
            }

            try
            {
                var dateTime = new DateTime();
                var dd = DateTime.TryParse(date, out dateTime);
                return Convert.ToDateTime(dateTime);
            }
            catch (Exception)
            {
                //date = DateTime.Today.Day.ToString("00") + "/" + DateTime.Today.Month.ToString("00") + "/" + DateTime.Today.Year.ToString();
                //var dateTime = new DateTime();
                //var dd = DateTime.TryParse(date, out dateTime);
                return DateTime.Today;
            }
        }

        public static DateTime ConverToDate(int day, int month, int year, int hour = 0, int minutes = 0, string meridian = "", string culture = "")
        {
            if (string.IsNullOrEmpty(culture))
                culture = "en-US";
            if (0 == (day))
                day = 1;
            if (0 == (month))
                month = 1;
            if (0 == (year))
                year = DateTime.Now.Year;
            if (0 == (hour))
                hour = 10;
            if (string.IsNullOrEmpty(meridian))
                meridian = "AM";

            CultureInfo choosenCulture = new CultureInfo(culture);

            string dateToConvert = $"{month}/{day}/{year} {hour}:{minutes} {meridian}";
            DateTime.TryParseExact(dateToConvert, "M/d/yyyy h:m tt", choosenCulture, DateTimeStyles.None, out DateTime dt);
            return dt;
        }

        public static DateTime ConverToDate(string date, string culture = "en-US")  
        {
            string format = "MM/dd/yyyy";
            if (string.IsNullOrEmpty(culture))
                culture = "en-US";
            else if (culture == "es-DO")
                format = "dd/MM/yyyy";

            var styles = DateTimeStyles.None;
            CultureInfo choosenCulture = new CultureInfo(culture);
            if (!string.IsNullOrEmpty(date))
            {
                var dt = DateTime.Now;
                // string dateToConvert = $"{date.Substring(6, 4){date.Substring(3, 2)}/{date.Substring(0, 2)}/}";
                DateTime.TryParseExact(date, format, choosenCulture, styles, out   dt);
               // DateTime.TryParse(date, choosenCulture, styles, out DateTime dt);
                return dt;
            }
            return DateTime.Now;
        }

        public static DateTime ConverToDate(string date, string hourAndMeridiam, string culture = "")
        {
            if (string.IsNullOrEmpty(culture))
                culture = "en-US";

            CultureInfo choosenCulture = new CultureInfo(culture);

            string dateToConvert = $"{date.Substring(3, 2)}/{date.Substring(0, 2)}/{date.Substring(6, 4)} {hourAndMeridiam}";
            DateTime.TryParseExact(dateToConvert, "MM/dd/yyyy h:m", choosenCulture, DateTimeStyles.None, out DateTime dt);
            return dt;
        }


    }
}
