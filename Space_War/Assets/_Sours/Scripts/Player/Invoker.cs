using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker 
{
    public void Move(GameObject gameObject, float x,int speed)
    {
        if(gameObject.transform.position.x > 8.8f&&x>0)
        {
            return;
        }
        if (gameObject.transform.position.x < -8.8f && x < 0)
        {
            return;
        }
        gameObject.transform.position += new Vector3(x,0,0)*speed*Time.deltaTime;
    }

}
