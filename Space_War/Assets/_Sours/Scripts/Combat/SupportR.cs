using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupportR : MonoBehaviour
{
    [SerializeField]
    GameObject[] supportPoints;
    [SerializeField]
    GameObject prefubSuppor;

    public void SpawnSupport(ref int SupportTiket, Transform playerT)
    {
        if(SupportTiket !<1)
        {
            SupportTiket -= 1;
            for(int i = 0; i < supportPoints.Length; i++)
            {
                supportPoints[i] = Instantiate(prefubSuppor,
                    supportPoints[i].transform.position, 
                    prefubSuppor.transform.rotation);
                supportPoints[i].transform.parent = playerT;
            }
        }
    }

}
