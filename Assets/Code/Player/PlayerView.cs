using System;
using UnityEngine;

namespace GB_UnityCSharp.Player
{
    public class PlayerView : MonoBehaviour
    {
        public PlayerView()
        {
            
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("RequiredItem"))
            {
                
            }
        }
    }
}