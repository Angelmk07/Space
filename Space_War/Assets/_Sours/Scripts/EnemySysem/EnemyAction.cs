using Enemy.EMovment;
using Enemy.Enemy;
using Enemy.EnemyLine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Enemy.EnemyHorizontalLine 
{

    public class EnemyAction : MonoBehaviour
    {
        public static Action Win;
        [SerializeField]
        private GameObject line;
        [SerializeField]
        private int _LiensCount;
        [SerializeField]
        private GameObject StartPoint;
        [SerializeField]
        private GameObject[] Lines;
        [Header("Spawn setings")]
        [SerializeField]
        private GameObject perfubEnemy;
        [SerializeField]
        private Vector3 vectorDistanceChange = new Vector3(1, 0, 0);
        private Vector3 vectorDistanceReal = Vector3.zero;
        [SerializeField]
        private int EnmemyOnline;


        [Header("Setings Move")]
        [SerializeField]
        private float speed;
        [SerializeField]
        private Vector3 vector = new Vector3(1, 0, 0);
        private EnemyMove _enemyMove;
        private int RealTimeEnemy;

        private void OnEnable()
        {
            EnemyBase.dead += OnEnemyDead;
        }
        private void OnDisable()
        {
            EnemyBase.dead -= OnEnemyDead;
        }

        private void Start()
        {
            _enemyMove = new();
            Lines = new GameObject[_LiensCount];
            Spawn(_LiensCount);
            RealTimeEnemy = _LiensCount * EnmemyOnline;
        }
        private void Update()
        {
            _enemyMove.Move(Lines, speed, vector);
        }

        public void Spawn(int value)
        {

            for (int i = 0; i < value; i++)
            {
                Lines[i] = Instantiate(line, StartPoint.transform.position + vectorDistanceReal, Quaternion.identity);
                Lines[i].GetComponent<EnemyLineControl>().Spawn(EnmemyOnline, perfubEnemy);
                vectorDistanceReal += vectorDistanceChange;
            }
        }
        void OnEnemyDead()
        {
            RealTimeEnemy--;
            if (RealTimeEnemy == 0)
            {
                Win?.Invoke();
            }
        }
    }

}
