namespace GB_UnityCSharp.UI
{
    public class UIInitializator
    {
        private UIController _uiController;

        public UIInitializator(Data data)
        {
            _uiController = new UIController(data);
        }

        public UIController GetController()
        {
            return _uiController;
        }
    }
}