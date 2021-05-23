using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    
    private static int totalPoint =0;
    private int point;
   

    private GameObject pointsText;


    // Start is called before the first frame update
    void Start()
    {
      
        this.pointsText = GameObject.Find("PointsText");

        if (tag == "SmallStarTag")
        {
            this.point = 10;
        }
        else if (tag == "LargeStarTag")
        {
            this.point = 15;
        }
        else if (tag == "SmallCloudTag")
        {
            this.point = 20;
        }
        else if (tag == "LargeCloudTag")
        {
            this.point = 25;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        totalPoint =totalPoint+ point;

        this.pointsText.GetComponent<Text>().text = totalPoint + " Pt";
    }
}
