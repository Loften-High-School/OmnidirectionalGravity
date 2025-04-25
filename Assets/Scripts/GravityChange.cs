using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChange : MonoBehaviour
{
     

    // Update is called once per frame
    void Update()
   
    {
        if(Input.GetKey("up"))
        {
            Physics2D.gravity = new Vector2(0,5f);
        }
        if(Input.GetKey("down"))
        {
            Physics2D.gravity = new Vector2(0,-5f);
        }
        if(Input.GetKey("right"))
        {
            Physics2D.gravity = new Vector2(5f,0);
        }
        if(Input.GetKey("left"))
        {
            Physics2D.gravity = new Vector2(-5f,0);
        }
    }
   
}
 