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

    void Collect()
    {
        //Anything that I type here, will be run
        Debug.Log("Hello World!");
    }
    void Respawn()
    {

    }
    void Score()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
