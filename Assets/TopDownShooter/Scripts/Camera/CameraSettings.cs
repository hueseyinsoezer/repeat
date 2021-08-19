using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TopDownShooter
{
    [CreateAssetMenu(menuName ="TopDownShooter/Camera/Camera Settings")]
    public class CameraSettings : ScriptableObject
    {
        [Header("Rotation")]
        [SerializeField] private float _rotationLerpSpeed;
        public float RotationLerpSpeed { get {return _rotationLerpSpeed;} }

        [Header("Position")]
        [SerializeField] private Vector3 _positionOffset;
        public Vector3 PositionOffset { get { return _positionOffset; } }

        [SerializeField] private float _positionLerpSpeed;
        public float PositionLerpSpeed { get { return _positionLerpSpeed; } }
    }

}
