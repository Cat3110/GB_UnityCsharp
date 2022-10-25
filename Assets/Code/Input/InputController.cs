using GB_UnityCSharp.Interfaces;
using GB_UnityCSharp.Player;
using UnityEngine;

namespace GB_UnityCSharp
{
    public class InputController : IController, IExecute
    {
        private InputActions _inputActions;
        private PlayerController _playerController;
        public InputController(InputActions inputActions, PlayerController playerController)
        {
            _playerController = playerController;
            _inputActions = inputActions;
            _inputActions.Enable();
        }

        public void Execute(float deltaTime)
        {
            _playerController.Move(_inputActions.Player.Move.ReadValue<Vector2>());
        }
    }
}