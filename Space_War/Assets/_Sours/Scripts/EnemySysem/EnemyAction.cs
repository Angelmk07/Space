using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAction : MonoBehaviour
{
    public static Action Win;
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
    int RealTimeEnemy;

    private void OnEnable()
    {
        Enemy.dead += OnEnemyDead;
    }
    private void OnDisable()
    {
        Enemy.dead -= OnEnemyDead;
    }

    private void Start()
    {
        _enemyMove = new();
        Lines = new GameObject[_LiensCount];
        Spawn(_LiensCount);
        RealTimeEnemy = _LiensCount *line.GetComponent<EnemyLineControl>().EnememyLive;
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
    void OnEnemyDead()
    {
        RealTimeEnemy--;
        if (RealTimeEnemy==0)
        {
            Win?.Invoke();
        }
    }
}
