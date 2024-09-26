using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [field: SerializeField]
    public int Speed { get; private set;}
    [field: SerializeField]
    public int Live { get; private set; }
    [field: SerializeField]
    public GameObject Bullet { get; private set; }
    public bool _isDead { get; private set; }
    public GameObject PlayerPosition { get; private set; }
    private void Awake()
    {
        PlayerPosition = gameObject;
        _isDead = false;
    }
    void TakeHit(int value)
    {
        Live = -value;
        _isDead = true;
    }
}
