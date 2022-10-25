using GB_UnityCSharp.Interfaces;
using GB_UnityCSharp.Player;
using GB_UnityCSharp.DataSaving;
using UnityEngine;

namespace GB_UnityCSharp
{
    public class InputInitializator : IInitializator
    {
        private InputController _inputController;
        public InputInitializator(PlayerController playerController, SaveDataController saveDataController)
        {
            InputActions inputActions = new InputActions();
            inputActions.Player.Save.performed += (ctx) =>
            {
                saveDataController.Save(playerController.GetModel());
            };
            inputActions.Player.Load.performed += (ctx) =>
            {
                saveDataController.Load(playerController.GetModel());
            };
            _inputController = new InputController(inputActions, playerController);
        }

        public IController GetController()
        {
            return _inputController;
        }
    }
}