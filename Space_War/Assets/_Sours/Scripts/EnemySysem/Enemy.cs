using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static Action dead;
    [SerializeField]
    private int live;
    [SerializeField]
    private int power;
    public int Power => power;
    //public int Live { get => live; set => live = value; }

    public void TakeHit(int value)
    {
        live =- value;
        if (live < 1)
        {
            dead?.Invoke();
            Destroy(gameObject);
        }
    }

}
