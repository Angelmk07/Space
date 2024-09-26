using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public void EnemyShoose(GameObject[] enemyes)
    {
        for(int i = enemyes.Length; i> 0; i--)
        {
           if(enemyes[i]!=null)
            {
                EnemyShooting(enemyes[i]);
                break;
            }
        }
    }
    void EnemyShooting(GameObject enemy)
    {

    }
}
