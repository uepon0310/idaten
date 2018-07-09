using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroll : MonoBehaviour
{

    private List<ScrollProperty> scrollPropertyList = new List<ScrollProperty>();

    private bool doScrollFlag;

    // Use this for initialization
    void Start()
    {
        doScrollFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (doScrollFlag == true)
        {
            DoScroll();
        }
    }

    //    public void SetScrollProperty(string objectName, GameObject objectImage1, GameObject objectImage2, int depth, float speed)
    public void SetScrollProperty(string objectName, Sprite objectImage1, Sprite objectImage2, int depth, float speed)
    {

        //        ScrollProperty prop = new ScrollProperty(objectName, objectImage1, objectImage2, depth, speed);
        ScrollProperty prop = new ScrollProperty(objectName, objectImage1, objectImage2, depth, speed);
        scrollPropertyList.Add(prop);

        //Set Inital
        float objectHeight = scrollPropertyList[scrollPropertyList.Count - 1].ObjectImage1.bounds.size.y;
        //        Vector4 objectHeight = scrollPropertyList[scrollPropertyList.Count - 1].ObjectImage1.border ;
        scrollPropertyList[scrollPropertyList.Count - 1].ObjectImage1.GetComponent<Renderer>().sortingOrder = scrollPropertyList[scrollPropertyList.Count - 1].Depth;
        scrollPropertyList[scrollPropertyList.Count - 1].ObjectImage1.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        scrollPropertyList[scrollPropertyList.Count - 1].ObjectImage2.transform.position = new Vector3(0.0f, objectHeight, 0.0f);
    }

    public void StartScroll()
    {
        doScrollFlag = true;
    }

    public void StopScroll()
    {
        doScrollFlag = false;
    }


    private void DoScroll()
    {
        for (int i = 0; i < scrollPropertyList.Count; i++)
        // foreach でも可
        {

            float objectHeight = scrollPropertyList[i].ObjectImage1.GetComponent<SpriteRenderer>().bounds.size.y;

            scrollPropertyList[i].ObjectImage1.transform.Translate(0, scrollPropertyList[i].Speed, 0);
            scrollPropertyList[i].ObjectImage2.transform.Translate(0, scrollPropertyList[i].Speed, 0);

            if (scrollPropertyList[i].ObjectImage1.transform.position.y <= -1 * objectHeight)
            {
                scrollPropertyList[i].ObjectImage1.transform.position = new Vector2(0, 0);
            }
            if (scrollPropertyList[i].ObjectImage2.transform.position.y <= 0)
            {
                scrollPropertyList[i].ObjectImage2.transform.position = new Vector2(0.0f, objectHeight);
            }

        }
    }
}

////////////////////////////////////////////////////
////////////////////////////////////////////////////
class ScrollProperty 
{
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
        ObjectImage2 = ObjImg2;
        Depth = ObjDepth;
        Speed = ObjSpeed;
    }
}