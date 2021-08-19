using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Lessons
{
    public class ControlRigidBody : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private RigidbodySettings _rigidbodySettings;

        private void Update()
        {
            bool spaceDown = Input.GetKeyDown(KeyCode.Space);
            if (spaceDown)
            {
                _rigidbody.AddForce(_rigidbodySettings.JumpForce, ForceMode.Impulse);
            }
        }
    }
}

