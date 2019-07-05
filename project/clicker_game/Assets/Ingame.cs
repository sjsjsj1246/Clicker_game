using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ingame : MonoBehaviour
{
    int myNum;
    public int pikaNum;
    public GameObject ball;
    public GameObject pikachu;
    public Text numTxt;

    void Start()
    {
        Debug.Log("Hello World!!");
        pikaNum = 20;
        numTxt.text="0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        //Debug.Log("Click!!");
        myNum++;
        numTxt.text = myNum.ToString();
        Debug.Log("myname : " + myNum);

        if(myNum == pikaNum)
        {
            pikachu.SetActive(true);
            ball.SetActive(false);
        }
    }
}
