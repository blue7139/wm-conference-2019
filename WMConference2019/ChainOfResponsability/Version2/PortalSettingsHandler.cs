namespace WMConference2019.ChainOfResponsibility.Version2
{
    class PortalSettingsHandler : ComponentSettingsHandler
    {
        public override string GetSettings(int componentId)
        {
            if (componentId > 20 && componentId <= 30)
            {
                return "Portal Settings";
            }
            else if (successor != null)
            {
                return successor.GetSettings(componentId);
            }

            return string.Empty;
        }
    }
}
