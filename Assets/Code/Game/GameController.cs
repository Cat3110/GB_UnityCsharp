using UnityEngine;

namespace GB_UnityCSharp
{
    public class GameController
    {
        private Data _data;
        public GameController(Data data)
        {
            _data = data;
        }

        public void AddPoints(object o)
        {
            if (o is RequiredItem) _data.Points++;
        }
    }
}