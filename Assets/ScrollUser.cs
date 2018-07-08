using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollUser : MonoBehaviour {
    public GameObject GameScreen1;
    public GameObject GameScreen2;
    public GameObject GameScreen3;
//    public GameObject GameScreen1A;
//    public GameObject GameScreen2A;
//    public GameObject GameScreen3A;

    public GameObject[] Sprite = new GameObject[2];

    public BackGroundScroll ScrollObject;


    // Use this for initialization
    void Start () {
        string objectName;
        GameObject objectImage1;
        GameObject objectImage2;
        int depth;
        float speed;

        objectName = "top";
        objectImage1 = GameScreen1;
        objectImage2 = Instantiate(GameScreen1);
        Sprite[0] = GameScreen1;
        Sprite[1] = GameScreen1;

        Sprite[0].transform.position = new Vector3(1f, 1f, 1f);
        objectImage1.transform.position = new Vector3(10f, 10f, 10f);

        Debug.Log(Sprite[0].transform.position);
        Debug.Log(Sprite[1].transform.position);
        Debug.Log(objectImage1.transform.position);


        depth = -1;
        speed = -0.05f;

        ScrollObject.SetScrollProperty(objectName, objectImage1, objectImage2, depth, speed);

        objectName = "middle";
        objectImage1 = GameScreen2;
        objectImage2 = Instantiate(GameScreen2);
        depth = -2;
        speed = -0.035f;

        ScrollObject.SetScrollProperty(objectName, objectImage1, objectImage2, depth, speed);

        objectName = "bottom";
        objectImage1 = GameScreen3;
        objectImage2 = Instantiate(GameScreen3);
        depth = -3;
        speed = -0.025f;

        ScrollObject.SetScrollProperty(objectName, objectImage1, objectImage2, depth, speed);



        ScrollObject.StartScroll();
    }

    // Update is called once per frame
    private int myCount = 1;
    void Update () {
        // 例
//        myCount++;

/*        if (myCount == 1000)
        {
            ScrollObject.StopScroll();  // 10秒後にスクロールがストップする
        }
*/
        if (myCount == 1)
        {
            ScrollObject.StartScroll(); // 20秒後にスクロールが再開する
        }

    }
}
