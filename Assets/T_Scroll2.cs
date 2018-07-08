using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class T_Scroll2 : MonoBehaviour
{

    /*======================================================================================
     *   T_Scrollは、背景スクロールするプログラムである。
     *   仕様シーンは、sceen、titleである。
     *======================================================================================*/



    public int ObjNumber = new int();
    public GameObject Obj1;
    public GameObject Obj2;

    void Start()
    {
        var SetPropertyList = new List<SetProperty>();
        Obj1 = new GameObject();
        Obj2 = new GameObject();
        Obj1 = GameObject.Find("background_back_fab");
        Obj2 = GameObject.Find("background_back_fab2");

        for (int i =0; i<=ObjNumber; i++)
        {
            SetPropertyList.Add(new SetProperty(0.05f, Obj1.GetComponent<SpriteRenderer>().bounds.size.y, Obj1, Obj2, -1,-3));
        }
    }

// Update is called once per frame
void Update()
    {
//        FuncScroll(ObjNumber);
    }

    //  初期値設定
    class SetProperty//クラスから関数に変更。
    {
        public SetProperty(float ScrollSpeed, float ObjectHeight, GameObject ObjectImage1, GameObject ObjectImage2, int ScrollDirection, int ObjectDepth)
        {
            this.ScrollSpeed = ScrollSpeed;
            this.ObjectHeight = ObjectHeight;
            this.ObjectImage1 = ObjectImage1;
            this.ObjectImage2 = ObjectImage2;
            this.ScrollDirection = ScrollDirection;
            this.ObjectDepth = ObjectDepth;
        }

        public float ScrollSpeed { get; set; }
        public float ObjectHeight { get; set; }
        public GameObject ObjectImage1 { get; set; }
        public GameObject ObjectImage2 { get; set; }
        public int ScrollDirection { get; set; }
        public int ObjectDepth { get; set; }
    }
    //リストを作る。スタートスクロール処理
}







/*

    private List<int> ObjectNumber = new List<int>();
      public float ScrollSpeed;
      public float ObjectHeight;
      public GameObject ObjectImage1;
      public GameObject ObjectImage2;
      public int ScrollDirection;
      public int ObjectDepth;

      public SetProperty()
        {
            ScrollSpeed = 
            ObjectNumber;
            for (int i = 0; i < ObjectNumber; i++)
            {




            }




            for (int i = 0; i < objectnumber; i++)
        {
            ObjHeight[i] = ObjImage1[i].GetComponent<SpriteRenderer>().bounds.size.y;
            ObjDepth[i] = ObjImage1[i].GetComponent<Renderer>().sortingOrder;
            ObjDepth[i] = -1 * i;
            ObjImage1[i].transform.position = new Vector2(0, 0);
            ObjImage2[i].transform.position = new Vector2(0, ObjHeight[i]);
        }
    }

     public   void FuncScroll(int objectnumber)
        {
            for (int i = 0; i < objectnumber; i++)
            {
                ObjImage1[i].transform.Translate(0, ScrollDirection[i] * ScrollSpeed[i], 0);
                ObjImage2[i].transform.Translate(0, ScrollDirection[i] * ScrollSpeed[i], 0);

                if (ObjImage1[i].transform.position.y <= ScrollDirection[i] * ObjHeight[i])
                {
                    ObjImage1[i].transform.position = new Vector2(0, 0);
                }
                if (ObjImage2[i].transform.position.y <= 0)
                {
                    ObjImage2[i].transform.position = new Vector2(0.0f,ObjHeight[i]);
                }
            }


        }
        //               v.transform.position = new Vector2(0.0f, -0.75f);
    }*/                                                         