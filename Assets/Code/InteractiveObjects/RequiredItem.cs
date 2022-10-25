using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace GB_UnityCSharp
{
    public class RequiredItem : InteractiveObjects
    {
        
        private void Update()
        {
            Fly();
        }

        protected override void Interaction()
        {
            base.Interaction();
        }
    }
}