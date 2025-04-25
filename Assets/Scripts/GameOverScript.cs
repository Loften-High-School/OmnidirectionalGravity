using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    public bool isAlive;
    // Start is called before the first frame update
    void Start()
    {
        isAlive = true;
        Debug.Log("Player is living");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}