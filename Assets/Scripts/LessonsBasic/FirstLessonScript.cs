using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace LessonsBasic//namespace objeleri gruplandýrmaya yarar
{
    public class FirstLessonScript : MonoBehaviour// MonoBehaviour olduðunda objelere eklenebilir oluyor
    {
        public float ondalikSayi = 0.05f;
        [SerializeField] float ondalikSayi2;
        private int tamSayi;
        int tamSayi2;
        bool richtigkeit = true;
        [SerializeField] private Vector3 ucFloat = new Vector3(1,2,3);
    }
}

