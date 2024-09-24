using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [field: SerializeField]
    public int Speed { get; private set; }
    [field: SerializeField]
    public int Power { get; private set; }
}
