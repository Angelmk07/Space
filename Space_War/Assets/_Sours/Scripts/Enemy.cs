using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    int live;
    [SerializeField]
    int power;

    void TakeHit(int value)
    {
        live =- value;
    }

}
