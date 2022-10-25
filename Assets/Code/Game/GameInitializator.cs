using GB_UnityCSharp.Interfaces;
using GB_UnityCSharp.Player;
using GB_UnityCSharp.DataSaving;
using GB_UnityCSharp.UI;
using UnityEngine;

namespace GB_UnityCSharp
{
    public class GameInitializator
    {
        private GameController _gameController;
        private SaveDataInitializator _saveDataInitializator;
        private InputInitializator _inputInitializator;
        private PlayerInitializator _playerInitializator;
        private UIInitializator _uiInitializator;
        public GameInitializator(Controllers controllers, Data data)
        {
            _saveDataInitializator = new SaveDataInitializator();
            _playerInitializator = new PlayerInitializator(data);
            _inputInitializator = new InputInitializator(_playerInitializator.GetController(), _saveDataInitializator.GetController());
            _uiInitializator = new UIInitializator(data);
            
            _gameController = new GameController(data);

            controllers.Add(_inputInitializator.GetController());
            controllers.Add(_playerInitializator.GetController());
            controllers.Add(new CameraController(Camera.main, data.cameraOffset, _playerInitializator.GetPlayerModel()));
            controllers.Add(_uiInitializator.GetController());
            
            AddPointsListeners(data.RequiredItems);
        }

        private void AddPointsListeners(InteractiveObjects[] items)
        {
            foreach (var item in items)
            {
                item.OnInteraction += _gameController.AddPoints;
            }
        }
    }
}