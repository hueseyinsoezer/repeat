using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace LessonsBasic//namespace objeleri gruplandırmaya yarar
{
    public class FirstLessonScript : MonoBehaviour// MonoBehaviour olduğunda objelere eklenebilir oluyor
    {
        public float ondalikSayi = 0.05f;
        [SerializeField] float ondalikSayi2;
        private int tamSayi;
        int tamSayi2;
        bool richtigkeit = true;
        [SerializeField] private Vector3 ucFloat = new Vector3(1,2,3);

        public float MyProperty { get; private set; }// property: get seti kendimiz yönetebiliyoruz. 
        //Scriptable Object'ler herhangi bir sahneye ihtiyaç duyulmadan ulaşılabilir objelerden. Prefablar gibi.
    }
}

