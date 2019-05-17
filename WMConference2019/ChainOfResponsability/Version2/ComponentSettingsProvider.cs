namespace WMConference2019.ChainOfResponsibility.Version2
{
    public class ComponentSettingsProvider
    {
        readonly ComponentSettingsHandler componentSettingHandler;

        public ComponentSettingsProvider()
        {
            componentSettingHandler = new CMFTagSettingsHandler();
            var menuItemSettingsHandler = new MenuItemSettingsHandler();
            var portalSettingsHandler = new PortalSettingsHandler();

            componentSettingHandler.SetSuccessor(menuItemSettingsHandler);
            menuItemSettingsHandler.SetSuccessor(portalSettingsHandler);
        }

        public string GetComponentSettings(int componentId)
        {
            return componentSettingHandler.GetSettings(componentId);
        }
    }
}
