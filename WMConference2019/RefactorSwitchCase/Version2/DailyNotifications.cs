using System;

namespace WMConference2019.RefactorSwitchCase.Version2
{ 
    class DailyNotifications
    {
        public void Notify(DayOfWeek day)
        {
            var notifier = CreateNotifier(day);
            notifier.Send();
        }

        #region Private
        private IDayFactory CreateNotifier(DayOfWeek day)
        {
            return Activator.CreateInstance(Type.GetType($"{day.ToString()}DayFactory")) as IDayFactory;
        }
        #endregion
    }
}
