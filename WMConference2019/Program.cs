using System;

namespace WMConference2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Settings VERSION 1:");
            var settings1 = new ChainOfResponsibility.Version1.ComponentSettingsProvider();
            Console.WriteLine("1:" + settings1.GetComponentSettings(1));
            Console.WriteLine("11:" + settings1.GetComponentSettings(11));
            Console.WriteLine("21:" + settings1.GetComponentSettings(21));

            Console.WriteLine();

            //Console.WriteLine("Settings VERSION 2:");
            //var settings2 = new ChainOfResponsibility.Version2.ComponentSettingsProvider();
            //Console.WriteLine("1:" + settings2.GetComponentSettings(1));
            //Console.WriteLine("11:" + settings2.GetComponentSettings(11));
            //Console.WriteLine("21:" + settings2.GetComponentSettings(21));

            //Console.WriteLine();

            //Console.WriteLine("Settings VERSION 3:");
            //var settings3 = new ChainOfResponsibility.Version3.ComponentSettingsProvider();
            //Console.WriteLine("1:" + settings3.GetComponentSettings(1));
            //Console.WriteLine("11:" + settings3.GetComponentSettings(11));
            //Console.WriteLine("21:" + settings3.GetComponentSettings(21));
        }

        #region CyclomaticComplexityTest
        public static string GetMessageV1(int month, int day)
        {
            string msg;

            if (month == 5 && day == 18)
            {
                msg = "Happy Codding"; 
            }
            else
            {
                msg = "Have a nice day";
            }

            return msg;
        }

        public static string GetMessageV2(int month, int day)
        {
            if (month == 5 && day == 18)
            {
                return "Happy Codding";
            }

            return "Have a Nice Day";
        }

        public static void Method(bool condition1, bool condition2)
        {
            if (condition1 || condition2 && (!condition1))
            {
                Console.WriteLine("Hello World!");
            }
        }

        public static void MethodReduce(bool condition1, bool condition2)
        {
            var negative = (!condition1);
            condition2 = condition2 && negative;
            condition2 = condition2 || condition1;
            if (condition2)
            {
                Console.WriteLine("Hello World!");
            }
        }
        #endregion
    }
}
