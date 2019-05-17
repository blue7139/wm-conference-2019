namespace WMConference2019.ChainOfResponsibility.Version2
{
    abstract class ComponentSettingsHandler

    {
        protected ComponentSettingsHandler successor;

        public void SetSuccessor(ComponentSettingsHandler successor)
        {
            this.successor = successor;
        }

        public abstract string GetSettings(int componentId);
    }
}
