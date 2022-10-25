using GB_UnityCSharp.Interfaces;
using UnityEngine;
using UnityEngine.Assertions.Must;

namespace GB_UnityCSharp.Player
{
    public class PlayerController : IController
    {
        private PlayerModel _playerModel;
        private GameObject _playerGameObject;
        private Rigidbody _playerRigidbody;
        
        public PlayerController(PlayerModel playerModel, GameObject playerGameObject)
        {
            _playerModel = playerModel;
            _playerGameObject = playerGameObject;
            _playerRigidbody = _playerGameObject.GetComponent<Rigidbody>();
        }

        public void Move(Vector2 moveVector)
        {
            _playerRigidbody.velocity = new Vector3(moveVector.x * _playerModel.PlayerSpeed, 0, moveVector.y * _playerModel.PlayerSpeed);
            _playerModel.Position = _playerGameObject.transform.position;
        }

        public PlayerModel GetModel()
        {
            return _playerModel;
        }
    }
}