using System;
using UnityEngine;

namespace GB_UnityCSharp.DataSaving
{
    [Serializable]
    public struct Vector3Serializable
    {
        public float x, y, z;

        private Vector3Serializable(float valueX, float valueY, float valueZ)
        {
            x = valueX;
            y = valueY;
            z = valueZ;
        }

        public static implicit operator Vector3(Vector3Serializable value)
        {
            return new Vector3(value.x, value.y, value.z);
        }

        public static implicit operator Vector3Serializable(Vector3 value)
        {
            return new Vector3Serializable(value.x, value.y, value.z);
        }
    }
}