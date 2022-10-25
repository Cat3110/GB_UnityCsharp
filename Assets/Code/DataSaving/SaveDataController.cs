using System.IO;
using GB_UnityCSharp.Interfaces;
using GB_UnityCSharp.Player;
using UnityEngine;

namespace GB_UnityCSharp.DataSaving
{
    public class SaveDataController : IController
    {
        private readonly JsonSaver<Vector3> _data;

        private const string Filename = "data.bat";
        private const string Dirname = "Save";

        private readonly string _path;
        public SaveDataController()
        {
            _data = new JsonSaver<Vector3>();
            _path = Path.Combine(Application.dataPath, Dirname);
        }

        public void Save(PlayerModel playerModel)
        {
            if (!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
            }
            
            _data.Save(playerModel.Position, Path.Combine(_path, Filename));
        }

        public void Load(PlayerModel playerModel)
        {
            var pos = _data.Load(Path.Combine(_path, Filename));
            playerModel.Position = pos;
        }
    }
}