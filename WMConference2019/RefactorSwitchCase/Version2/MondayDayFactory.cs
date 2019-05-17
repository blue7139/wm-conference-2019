using System;

namespace WMConference2019.RefactorSwitchCase.Version2
{
    public class MondayDayFactory : IDayFactory
    {
        public void Send()
        {
            Console.WriteLine("Today is Monday!");
        }
    }
}
