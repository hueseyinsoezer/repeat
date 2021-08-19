using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Lessons
{
    public class RotateObject : MonoBehaviour
    {
        [SerializeField] private RotateSettings _rotateSettings;//Settings Scriptable objeyi monobehavior scriptine tan�mlad�k.
        private void Update()
        {
            //transform.Rotate(Vector3.up, _speed);//transform.Rotate(y�n, a��) Bu fonksiyonda d�n�� h�z� s�rekli �al��aca�� i�in saniye ba�� frame ba�l�d�r.
            transform.Rotate(Vector3.up, _rotateSettings.Speed*Time.deltaTime);//100 frame per second 100*0.1=10 /////// 50 frame per second 50*0.2 = 10
        }
    }

}

