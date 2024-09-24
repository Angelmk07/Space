using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [field: SerializeField]
    public int Speed { get; private set;}
    [field: SerializeField]
    public int Live { get; private set; }
}
