using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAction : MonoBehaviour
{
    [SerializeField]
    GameObject line;
    [SerializeField]
    int _LiensCount;
    [SerializeField]
    GameObject StartPoint;
    [SerializeField]
    private GameObject[] Lines;
    [Header("Spawn setings")]

    [SerializeField]
    Vector3 vectorDistanceChange = new Vector3(1, 0, 0);
    Vector3 vectorDistanceReal = Vector3.zero;



    [Header("Setings Move")]
    [SerializeField]
    float speed;
    [SerializeField]
    Vector3 vector = new Vector3(1, 0, 0);
    EnemyMove _enemyMove;

    private void Start()
    {
        _enemyMove = new();
        Lines = new GameObject[_LiensCount];
        Spawn(_LiensCount);
    }
    private void Update()
    {
        _enemyMove.Move(Lines, speed, vector);
    }

    public void Spawn(int value)
    {

        for (int i = 0; i < value; i++)
        {
            Lines[i] =Instantiate(line, StartPoint.transform.position + vectorDistanceReal, Quaternion.identity);
            vectorDistanceReal += vectorDistanceChange;
        }
    }
}
