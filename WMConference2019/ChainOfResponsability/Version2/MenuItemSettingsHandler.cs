namespace WMConference2019.ChainOfResponsibility.Version2
{
    class MenuItemSettingsHandler : ComponentSettingsHandler
    {
        public override string GetSettings(int componentId)
        {
            if (componentId > 10 && componentId <= 20)
            {
                return "Menu Item Settings";
            }
            else if (successor != null)
            {
                return successor.GetSettings(componentId);
            }

            return string.Empty;
        }
    }
}
