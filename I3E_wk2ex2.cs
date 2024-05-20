using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int myScore = 5;
    int collectiblesLeft = 15;
    bool collected = false;
    float expirationTime = 5.5f;
    string spawnArea= "Tutorial";

    private void Start()
    {
        for 
    }
    void Collect()
    {
        //Anything that I type here, will be run
        if(collected)
        {
            //Dont get collected agian
        }
        else
        {
            //Let player collect me and increase score
            //playerScore += myScore;
        }
    }
    void Animate()
    {
        //Do animation here
        while(collected) 
        {

        }
    }
    void Respawn()
    {

    }
    void Score()
    {

    }

    // Start is called before the first frame update
    int a = 2;
    int x = 3;
    int y = 4;
    void Start()
    {
        void QuickMath()
        {
            if (a < x)
            {
                a += y;
                if (result < x)
                {
                    Debug.Log("x is the biggest number");
                }
                else
                {
                    Debug.Log("x is not the biggest number");
                }
            }
            else
            {
                Debug.Log(a%y);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
