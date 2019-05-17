namespace WMConference2019.ChainOfResponsibility.Version3
{
    class PortalSettingsHandler : ComponentSettingsHandler
    {
        public override string GetSettings(int componentId)
        {
            if (componentId > 20 && componentId <= 30)
            {
                return "Portal Settings";
            }
            else
            {
                return base.GetSettings(componentId);
            }
        }
    }
}
