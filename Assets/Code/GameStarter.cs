using System;
using UnityEngine;

namespace GB_UnityCSharp
{
    public sealed class GameStarter : MonoBehaviour
    {
        private Controllers _controllers;
        private Data _data;

        private void Start()
        {
            _data = Resources.Load<Data>("Data/GameData");
            _controllers = new Controllers();
            
            new GameInitializator(_controllers, _data);
        }

        private void Update()
        {
            _controllers.Execute(Time.deltaTime);
        }
    }
}