using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroll_old : MonoBehaviour {

    private int MaxObjectNumber = new int();
    private List<ScrollProperty> ScrollPropertyList = new List<ScrollProperty>();

    public GameObject gameScreen1;
    public GameObject gameScreen2;
    public GameObject gameScreen3;

    // Use this for initialization
    void Start() {
        //
        //GetComponent<クラス名>().method();
        //        background.GetComponent<ScrollUser>().
        //Find("ゲームオブジェクト名").GetComponent<クラス名>().method();

        

        string objectName;      //ユーザーの値は ここはいらない
        GameObject objectImage1;      //ユーザーの値は ここはいらない
        GameObject objectImage2;      //ユーザーの値は ここはいらない
        int depth;      //ユーザーの値は ここはいらない
        float speed;      //ユーザーの値は ここはいらない

        objectName = "top";             //ユーザーの値は ここはいらない
        objectImage1 = gameScreen1;     //ユーザーの値は ここはいらない
        objectImage2 = gameScreen1;     //ユーザーの値は ここはいらない
        depth = -1;                     //ユーザーの値は ここはいらない
        speed = 0.025f;                 //
        ScrollPropertyList.Add(new ScrollProperty(objectName,objectImage1, objectImage2, depth, speed));//ここはいる。

        objectName = "middle";
        objectImage1 = gameScreen2;
        objectImage2 = gameScreen2;
        depth = -2;
        speed = 0.05f;

        ScrollPropertyList.Add(new ScrollProperty(objectName, objectImage1, objectImage2, depth, speed));

        objectName = "bottom";
        objectImage1 = gameScreen3;
        objectImage2 = gameScreen3;
        depth = -3;
        speed = 0.025f;

        ScrollPropertyList.Add(new ScrollProperty(objectName, objectImage1, objectImage2, depth, speed));

        objectName = "top";
        objectImage1 = gameScreen1;
        objectImage2 = gameScreen1;
        depth = -1;
        speed = -5f;      //ユーザーの値は ここはいらない

        //sStartScroll(objectName, objectImage1, objectImage2, depth, speed);
    }

    // Update is called once per frame
    void Update() {
/*        p
        DoScroll(void){フラグを立ってたら呼ばれる。
        DoScrollFlag == 1{
                DoScroll(void);*/
            }
/*
        string objectName;
        GameObject objectImage1;
        GameObject objectImage2;
        int depth;
        float speed;

        objectName = "top";
        objectImage1 = gameScreen1;
        objectImage2 = gameScreen1;
        depth = -1;
        speed = -2.5f;

        StartScroll(objectName, objectImage1, objectImage2, depth, speed);
*/
    }


    //    private float objectHeight = new float();
//    private float objectHeight;

/*    public void SetScrollProperty(string objectName, GameObject objectImage1, GameObject objectImage2, int depth, float speed)
    {
        //objectName = objectName;
        objectHeight = objectImage1.GetComponent<SpriteRenderer>().bounds.size.y;
        objectImage1.GetComponent<Renderer>().sortingOrder = depth;
        objectImage1.transform.position = new Vector2(0, 0);
        objectImage2.transform.position = new Vector2(0, objectHeight);
        //add
        //add ScrollPropertyList.Add(new ScrollProperty(objectName, objectImage1, objectImage2, depth, speed));//ここはいる。
    }
*/
/*    public void StartScroll(string objectName, GameObject objectImage1, GameObject objectImage2, int depth, float speed)
    {
        //objectName = objectName;
        objectHeight = objectImage1.GetComponent<SpriteRenderer>().bounds.size.y;
        objectImage1.GetComponent<Renderer>().sortingOrder = depth;
        objectImage1.transform.Translate(0, speed, 0);
        objectImage2.transform.Translate(0, speed + objectHeight, 0);
//        objectImage2.transform.Translate(0, speed , 0);

        if (objectImage1.transform.position.y <= -1 * objectHeight)
        {
            objectImage1.transform.position = new Vector2(0, 0);
        }
        if (objectImage2.transform.position.y <= 0)
        {
            objectImage2.transform.position = new Vector2(0.0f, objectHeight);
        }
    }
    */
/*    public void StopScroll()
    {

    }
*/

/*
class ScrollProperty
{
    public string ObjectName;
    public GameObject ObjectImage1;
    public GameObject ObjectImage2;
    public int Depth;
    public float Speed;

    public ScrollProperty(string ObjName, GameObject ObjImg1, GameObject ObjImg2, int ObjDepth, float ObjSpeed)
    {
        ObjectName = ObjName;
        ObjectImage1 = ObjImg1;
        ObjectImage2 = ObjImg2;
        Depth = ObjDepth;
        Speed = ObjSpeed;
    }
}
*/






