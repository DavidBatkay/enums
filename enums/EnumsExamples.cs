using System;
namespace EnumsExamples
{
    [Flags]   
    public enum DayOfWeek
    {
        Monday=1<<0,
        Tuesday=1<<1,
        Wednesday=1<<3,
        Thursday= 1 << 4,
        Friday= 1 << 5,
        Saturday= 1 << 6,
        Sunday= 1 << 7
    }
}