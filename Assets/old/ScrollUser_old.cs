using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ScrollUser_old : MonoBehaviour
{
    public GameObject gameScreen1;
    public GameObject gameScreen2;
    public GameObject gameScreen3;

    public BackGroundScroll ScrollObject;


    void Start()
    {
        string objectName;
        GameObject objectImage1;
        GameObject objectImage2;
        int   depth;
        float speed;

        objectName = "top";
        objectImage1 = gameScreen1;
        objectImage2 = gameScreen1;
        depth = -1;
        speed = -0.5f;

        ScrollObject.SetScrollProperty(objectName, objectImage1, objectImage2, depth, speed);

        objectName = "middle";
        objectImage1 = gameScreen2;
        objectImage2 = gameScreen2;
        depth = -2;
        speed = -0.75f;

        ScrollObject.SetScrollProperty(objectName, objectImage1, objectImage2, depth, speed);

        objectName = "bottom";
        objectImage1 = gameScreen3;
        objectImage2 = gameScreen3;
        depth = -3;
        speed = -1.0f;

        ScrollObject.SetScrollProperty(objectName, objectImage1, objectImage2, depth, speed);
/*
        objectName = "top";
        objectImage1 = gameScreen1;
        objectImage2 = gameScreen1;
        depth = -1;
        speed = -5f;

        ScrollObject.StartScroll(objectName, objectImage1, objectImage2, depth, speed);
*/
    }

    // Update is called once per frame
    void Update()
    {
        string objectName;
        GameObject objectImage1;
        GameObject objectImage2;
        int depth;
        float speed;

        objectName = "top";
        objectImage1 = gameScreen1;
        objectImage2 = gameScreen1;
        depth = -1;
        speed = -0.075f;

//        ScrollObject.StartScroll(objectName, objectImage1, objectImage2, depth, speed);//引数がない。ScrollObject.StartScroll()BackGroundScrollのタイミング
//        ScrollObject.DoScroll(objectName, objectImage1, objectImage2, depth, speed);//引数がない。ScrollObject.StartScroll()BackGroundScrollのタイミング

        objectName = "middle";
        objectImage1 = gameScreen2;
        objectImage2 = gameScreen2;
        depth = -2;
        speed = -0.05f;

 //       ScrollObject.StartScroll(objectName, objectImage1, objectImage2, depth, speed);

        objectName = "bottom";
        objectImage1 = gameScreen3;
        objectImage2 = gameScreen3;
        depth = -3;
        speed =- 0.025f;

 //       ScrollObject.StartScroll(objectName, objectImage1, objectImage2, depth, speed);

    }

}