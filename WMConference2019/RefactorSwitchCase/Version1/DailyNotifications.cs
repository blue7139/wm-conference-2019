using System;

namespace WMConference2019.RefactorSwitchCase.Version1
{
    class DailyNotifications
    {
        public void Notify(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Today is Monday!");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Today is Tuesday!");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Today is Wednesday!");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Today is Thursday!");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Today is Friday!");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Today is Saturday!");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Today is Sunday!");
                    break;
            }
        }
    }
}
