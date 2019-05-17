namespace WMConference2019.ChainOfResponsibility.Version2
{
    class CMFTagSettingsHandler : ComponentSettingsHandler
    {
        public override string GetSettings(int componentId)
        {
            if (componentId > 0 && componentId <= 10)
            {
                return "CMF Tag Settings";
            }
            else if (successor != null)
            {
                return successor.GetSettings(componentId);
            }

            return string.Empty;
        }
    }
}
