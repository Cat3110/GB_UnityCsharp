using GB_UnityCSharp.Interfaces;

namespace GB_UnityCSharp.DataSaving
{
    public class SaveDataInitializator
    {
        private SaveDataController _saveDataController;
        public SaveDataInitializator()
        {
            _saveDataController = new SaveDataController();
        }

        public SaveDataController GetController()
        {
            return _saveDataController;
        }
    }
}