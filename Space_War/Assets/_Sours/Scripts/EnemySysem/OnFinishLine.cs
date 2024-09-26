using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnFinishLine : MonoBehaviour
{
    GameObject FinishScrin;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 9)
        {
            FinishScrin.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

}
