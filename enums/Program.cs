namespace enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek friday = DayOfWeek.Friday;
            Console.WriteLine(friday);

            int fridayAsInt = (int)friday;
            Console.WriteLine(fridayAsInt);

            DayOfWeek day = (DayOfWeek)100;
            Console.WriteLine(day);

            /*
             * 2^0= 0 0 0 0 0 0 0 1 (Monday)
             * 2^1= 0 0 0 0 0 0 1 0 (Tuesday)
             * 2^2= 0 0 0 0 0 1 0 0 (Wednesday)
             * 2^3= 0 0 0 0 1 0 0 0 (Thursday)
             * 2^4= 0 0 0 1 0 0 0 0 (Friday)
             * 2^5= 0 0 1 0 0 0 0 0 (Saturday)
             * 2^6= 0 1 0 0 0 0 0 0 (Sunday)
             * ------------------------------
             *      0 1 0 0 0 0 0 0 (Saturday+Sunday)
             * 
             */

            DayOfWeek weekend = DayOfWeek.Sunday;
            Console.WriteLine(weekend);
            bool isMondayPartOfWeekend = (weekend & DayOfWeek.Monday);
            Console.WriteLine("Monday is part of combo: " + isMondayPartOfWeekend);
            bool isSaturdayPartOfWeekend = (weekend & DayOfWeek.Saturday);
            Console.WriteLine("Saturday is part of combo: " + isSaturdayPartOfWeekend);
            if(Enum.IsDefined(typeof(DayOfWeek), valueAsInt))
            AccessPermissions permission = (AccessPermissions)100;
            Console.WriteLine(permission);

            Console.Write("Enter a day: ");
            string dayValue=Console.ReadLine();

            bool canConvert = Enum.TryParse(typeof(DayOfWeek), dayValue, out object result);
            if(canConvert)
            {
                DayOfWeek converterDayOfWeek = (DayOfWeek)result;
                Console.WriteLine(converterDayOfWeek);
            }
            else 
            {
                Console.WriteLine($"'{dayValue}'doesn't represent a valid DayOfWeek");
            }
            //varianta 2
            bool canConvert2 = Enum.TryParse(dayValue, out DayOfWeek resultDayOfWeek);
            if (canConvert2)
            {
                DayOfWeek converterDayOfWeek = (DayOfWeek)result;
                Console.WriteLine(converterDayOfWeek);
            }
            else
            {
                Console.WriteLine($"'{dayValue}'doesn't represent a valid DayOfWeek");
            }
        }
    }
}