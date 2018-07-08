using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserSetImage : MonoBehaviour
{
    //    public Sprite       GameScreen1;
    //    public Sprite       GameScreen2;
    //    public Sprite       GameScreen3;
    // Use this for initialization
    public Sprite objectImage1;
    public Sprite objectImage2;


    public BackGroundScroll ScrollObject;

    void Start()
    {
        objectImage1 = Resources.Load<Sprite>("background_back_fab");
        objectImage2 = Resources.Load<Sprite>("background_back_fab");
        int depth;
        float speed;
        string objectName;

        objectName = "top";

        depth = -1;
        speed = -0.05f;

        ScrollObject.SetScrollProperty(objectName, objectImage1, objectImage2, depth, speed);

        ScrollObject.StartScroll();

    }

    // Update is called once per frame
    private int myCount = 1;
    void Update()
    {
        if (myCount == 1)
        {
            ScrollObject.StartScroll();
        }

    }
}