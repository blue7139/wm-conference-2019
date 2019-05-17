using System;

namespace WMConference2019.RefactorSwitchCase.Version2
{
    public class SaturdayDayFactory : IDayFactory
    {
        public void Send()
        {
            Console.WriteLine("Today is Saturday!");
        }
    }
}
