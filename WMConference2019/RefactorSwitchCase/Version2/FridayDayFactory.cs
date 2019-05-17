using System;

namespace WMConference2019.RefactorSwitchCase.Version2
{
    public class FridayDayFactory : IDayFactory
    {
        public void Send()
        {
            Console.WriteLine("Today is Friday!");
        }
    }
}
