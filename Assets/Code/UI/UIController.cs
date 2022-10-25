using GB_UnityCSharp.Interfaces;
using UnityEngine;
using UnityEngine.UIElements;

namespace GB_UnityCSharp.UI
{
    public class UIController : IController, IExecute
    {
        private Data _data;
        public UIController(Data data)
        {
            _data = data;
        }

        public void Execute(float deltaTime)
        {
            _data.Root.Q<Label>("required-items-count").text = $"Points: {_data.Points}";
        }
    }
}