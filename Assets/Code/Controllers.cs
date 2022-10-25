using System.Collections.Generic;
using GB_UnityCSharp.Interfaces;
using UnityEngine;

namespace GB_UnityCSharp
{
    public sealed class Controllers : IExecute
    {
        private List<IExecute> _executeControllers;

        public Controllers()
        {
            _executeControllers = new List<IExecute>();
        }

        public void Add(IController controller)
        {
            if (controller is IExecute executeController)
                _executeControllers.Add(executeController);
        }

        public void Execute(float deltaTime)
        {
            foreach (var controller in _executeControllers)
            {
                controller.Execute(deltaTime);
            }
        }
    }
}