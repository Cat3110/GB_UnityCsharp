using UnityEngine;
using Object = UnityEngine.Object;

namespace GB_UnityCSharp.Player
{
    public class PlayerInitializator
    {
        private PlayerController _playerController;
        private PlayerModel _playerModel;
        public PlayerInitializator(Data data)
        {
            _playerModel = new PlayerModel(data.playerInitialPosition, data.playerSpeed);
            var playerGameObject = Object.Instantiate(data.playerPrefab, data.playerInitialPosition, Quaternion.identity);
            playerGameObject.AddComponent<PlayerView>();

            _playerController = new PlayerController(_playerModel, playerGameObject);
        }

        public PlayerController GetController()
        {
            return _playerController;
        }

        public PlayerModel GetPlayerModel()
        {
            return _playerModel;
        }
    }
}