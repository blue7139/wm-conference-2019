namespace WMConference2019.ChainOfResponsibility.Version1
{
    public class ComponentSettingsProvider
    {
        public string GetComponentSettings(int componentId)
        {
            var componentSettings = GetCMFTagSettings(componentId);

            if (string.IsNullOrEmpty(componentSettings))
            {
                componentSettings = GetMenuItemSettings(componentId);

                if (string.IsNullOrEmpty(componentSettings))
                {
                    componentSettings = GetPortalSettings(componentId);
                }
            }

            return componentSettings;
        }

        #region private
        private string GetCMFTagSettings(int componentId)
        {
            if (componentId > 0 && componentId <=10)
            { 
                return "CMF Tag Settings";
            }

            return string.Empty;
        }

        private string GetMenuItemSettings(int componentId)
        {
            if (componentId > 10 && componentId <= 20)
            {
                return "Menu Item Settings";
            }

            return string.Empty;
        }

        private string GetPortalSettings(int componentId)
        {
            if (componentId > 20 && componentId <= 30)
            {
                return "Portal Settings";
            }

            return string.Empty;
        }
        #endregion
    }
}
