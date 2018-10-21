using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour{

    public GameObject goldPrefab;

    // Use this for initialization
    void Start()
    {
        Q1();
        //Q2();
        //Q3();
    }
    public void Q1()
    {
        for (int i = 0; i < 7; i++)
        {

            float x;
            float y;
            float y2;

            x = -10.5f + 3.5f * i;
            y = 10.5f + (-3.5f) * i;
            y2 = -10.5f + 3.5f * i;

            Instantiate(goldPrefab, new Vector3(x, y, 0), Quaternion.identity);
            Instantiate(goldPrefab, new Vector3(x, y2, 0), Quaternion.identity);
        }
    }

    public void Q2()
    {

        float x;
        float y;
        float x2;
        float y2;

        for (int i = 0; i < 3; i++)
        {

    

            x = -7f + 7f * i;
            y = -7f + 7f * i;
            x2 = 7f + -7f * i;
            y2 = -7f + 7f * i;

            Instantiate(goldPrefab, new Vector3(x, 0, 0), Quaternion.identity);

        }


        for (int i = 0; i < 2; i++)
        {

            x = -7f + 14f * i;
            y = -7f + 14f * i;
            x2 = 7f + -14f * i;
            y2 = -7f + 14f * i;

            Instantiate(goldPrefab, new Vector3(0, y, 0), Quaternion.identity);
            Instantiate(goldPrefab, new Vector3(x, y, 0), Quaternion.identity);
            Instantiate(goldPrefab, new Vector3(x2, y2, 0), Quaternion.identity);

        }

    }

    public void Q3()
    {
        int i = 0;
        int j = 0;

        float x;
        float y;
        float x2;
        float y2;

        while (i < 3)
        {
            x = -7f + 7f * i;
            y = -7f + 7f * i;
       
            Instantiate(goldPrefab, new Vector3(x, 0, 0), Quaternion.identity);

            i = i + 1;
        }

        while (j < 2)
        {
       
            x = -7f + 14f * j;
            y = -7f + 14f * j;
            x2 = 7f + -14f * j;
            y2 = -7f + 14f * j;

            Instantiate(goldPrefab, new Vector3(0, y, 0), Quaternion.identity);
            Instantiate(goldPrefab, new Vector3(x, y, 0), Quaternion.identity);
            Instantiate(goldPrefab, new Vector3(x2, y2, 0), Quaternion.identity);

            j = j + 1;
        }
    }
}

   
