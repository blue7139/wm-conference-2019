namespace WMConference2019.ChainOfResponsibility.Version3
{
    abstract class ComponentSettingsHandler

    {
        protected ComponentSettingsHandler successor;

        public void SetSuccessor(ComponentSettingsHandler successor)
        {
            this.successor = successor;
        }

        public virtual string GetSettings(int componentId)
        {
            return successor?.GetSettings(componentId);
        }
    }
}
