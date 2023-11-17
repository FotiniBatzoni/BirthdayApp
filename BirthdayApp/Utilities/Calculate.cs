
using System.Globalization;


namespace BirthdayApp.Utilities
{
    public static class Calculate
    {
        static DateTime currentDate = DateTime.Now;

        public static DateTime ParseGreekDate(string dateString)
        {
            CultureInfo greekCulture = new CultureInfo("el-GR");
            string dateFormat = "dddd, dd MMMM yyyy";
            return DateTime.ParseExact(dateString, dateFormat, greekCulture);
        }

        public static int Age(string birthday)
        { 
            if (!string.IsNullOrEmpty(birthday))
            {
                DateTime birthDate = ParseGreekDate(birthday);

                int age = currentDate.Year - birthDate.Year;
                if (currentDate.Month < birthDate.Month 
                    || (currentDate.Month == birthDate.Month 
                    && currentDate.Day < birthDate.Day))
                {
                    age--;
                }
                return age;

            }
            else
            {
                return -1;
            }

        }

        public static int DaysUntilBirthday(string birthday)
        {
            if (!string.IsNullOrEmpty(birthday))
            {
                DateTime birthDate = ParseGreekDate(birthday);

                DateTime today = DateTime.Now;
                DateTime nextBirthday = new DateTime(today.Year, birthDate.Month, birthDate.Day);

                if (today > nextBirthday)
                {
          
                    nextBirthday = nextBirthday.AddYears(1);
                }

                int daysUntilBirthday = (nextBirthday - today).Days;
                return daysUntilBirthday;
            }
            else
            {
                return -1;
            }
        }

        public static DateTime ParsedDate(string birthdayString)
        {
            var cultureInfo = new CultureInfo("el-GR");
            var dateTimeStyle = DateTimeStyles.None;

            if (!string.IsNullOrEmpty(birthdayString))
            {
                // Parsing the string date into DateTime using the appropriate format
                DateTime parsedDate;
                if (DateTime.TryParseExact(birthdayString, "dddd, dd MMMM yyyy", cultureInfo, dateTimeStyle, out parsedDate))
                {
                    return parsedDate;
                }
            }
            return DateTime.MinValue;
        }
    }
}
