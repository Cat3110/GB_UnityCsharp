using System;
using UnityEngine;

namespace GB_UnityCSharp
{
    public abstract class InteractiveObjects : MonoBehaviour
    {
        public event Action<object> OnInteraction;
        protected virtual void Interaction()
        {
            OnInteraction?.Invoke(this);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Interaction();
                Destroy(gameObject);
            }
        }

        protected void Fly()
        {
            transform.localPosition = new Vector3(transform.localPosition.x,
                Mathf.PingPong(Time.time / 6, 0.15f) + 0.5f,
                transform.localPosition.z);

        }
    }
}