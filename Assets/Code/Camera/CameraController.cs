using System;
using GB_UnityCSharp.Interfaces;
using GB_UnityCSharp.Player;
using UnityEngine;

namespace GB_UnityCSharp
{
    public class CameraController : IController, IExecute
    {
        private Vector3 _offset;
        private PlayerModel _playerModel;
        private Camera _camera;

        public CameraController(Camera camera, Vector3 offset, PlayerModel playerModel)
        {
            _offset = offset;
            _playerModel = playerModel;
            _camera = camera;
        }

        public void Execute(float deltaTime)
        {
            _camera.transform.position = _playerModel.Position + _offset;
        }
    }
}