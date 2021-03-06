using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TopDownShooter.PlayerMovement
{
    [CreateAssetMenu(menuName ="TopDownShooter/Player/Player Movement Settings")]
    public class PlayerMovementSettings : ScriptableObject
    {
        public float HorizontalSpeed = 5;
        public float VerticalSpeed = 5;
        public float JumpSpeed = 5;
    }
}

