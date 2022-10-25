using UnityEngine;

namespace GB_UnityCSharp.Player
{
    public class PlayerModel
    {
        private Vector3 _position;
        private float _playerSpeed;

        public Vector3 Position
        {
            get => _position;
            set => _position = value;
        }

        public float PlayerSpeed => _playerSpeed;

        public PlayerModel(Vector3 position, float playerSpeed)
        {
            _position = position;
            _playerSpeed = playerSpeed;
        }
    }
}