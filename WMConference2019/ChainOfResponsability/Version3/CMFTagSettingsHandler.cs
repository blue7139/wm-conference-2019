namespace WMConference2019.ChainOfResponsibility.Version3
{
    class CMFTagSettingsHandler : ComponentSettingsHandler
    {
        public override string GetSettings(int componentId)
        {
            if (componentId > 0 && componentId <= 10)
            {
                return "CMF Tag Settings";
            }
            else
            {
                return base.GetSettings(componentId);
            }
        }
    }
}
