namespace WMConference2019.ChainOfResponsibility.Version1
{
    public class ComponentSettingsProvider
    {
        public string GetComponentSettings()
        {
            var componentSettings = GetCMFTagSettings();

            if (string.IsNullOrEmpty(componentSettings))
            {
                componentSettings = GetMenuItemSettings();

                if (string.IsNullOrEmpty(componentSettings))
                {
                    componentSettings = GetPortalSettings();
                }
            }

            return componentSettings;
        }

        #region private
        private string GetCMFTagSettings()
        {
            return GetRandomSettings("CMF Tag Settings");
        }

        private string GetMenuItemSettings()
        {
            return GetRandomSettings("Menu Item Settings");
        }

        private string GetPortalSettings()
        {
            return GetRandomSettings("Portal Settings");
        }

        private string GetRandomSettings(string value)
        {
            var random = new System.Random();
            var list = new string[] { string.Empty, value };
            int index = random.Next(list.Length);

            return list[index];
        }
        #endregion
    }
}
