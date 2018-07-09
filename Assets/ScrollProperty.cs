using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollProperty : MonoBehaviour {

        /*
            public string ObjectName;
            public GameObject ObjectImage1;
            public GameObject ObjectImage2;
            public int Depth;
            public float Speed;
        */
        public string ObjectName;
        public GameObject ObjectImage1;
        public GameObject ObjectImage2;
        public int Depth;
        public float Speed;

        //public ScrollProperty(string ObjName, GameObject ObjImg1, GameObject ObjImg2, int ObjDepth, float ObjSpeed)
        public ScrollProperty(string ObjName, Sprite ObjImg1, Sprite ObjImg2, int ObjDepth, float ObjSpeed)
        {
            ObjectName = ObjName; 
            ObjectImage1 = Instantiate(ObjImg1);
            ObjectImage2 = Instantiate(ObjImg2);
            Depth = ObjDepth;
            Speed = ObjSpeed;
        }
    }
}