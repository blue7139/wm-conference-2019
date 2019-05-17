namespace WMConference2019.ChainOfResponsibility.Version3
{
    class MenuItemSettingsHandler : ComponentSettingsHandler
    {
        public override string GetSettings(int componentId)
        {
            if (componentId > 10 && componentId <= 20)
            {
                return "Menu Item Settings";
            }
            else
            {
                return base.GetSettings(componentId);
            }
        }
    }
}
