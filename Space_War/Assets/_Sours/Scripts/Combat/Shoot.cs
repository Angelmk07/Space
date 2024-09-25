using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public void Shooting(GameObject prefab, GameObject startPoint)
    {

            Instantiate(prefab,
           startPoint.transform.position+new Vector3(0,1f,0),
           prefab.transform.rotation);

    }
}
