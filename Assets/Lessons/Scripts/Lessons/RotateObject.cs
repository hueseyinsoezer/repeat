using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Lessons
{
    public class RotateObject : MonoBehaviour
    {
        [SerializeField] private RotateSettings _rotateSettings;//Settings Scriptable objeyi monobehavior scriptine tanýmladýk.
        private void Update()
        {
            //transform.Rotate(Vector3.up, _speed);//transform.Rotate(yön, açý) Bu fonksiyonda dönüþ hýzý sürekli çalýþacaðý için saniye baþý frame baðlýdýr.
            transform.Rotate(Vector3.up, _rotateSettings.Speed*Time.deltaTime);//100 frame per second 100*0.1=10 /////// 50 frame per second 50*0.2 = 10
        }
    }

}

