using Enemy.Enemy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Enemy.EnemyLine 
{
    public class EnemyLineControl : MonoBehaviour
    {
        public GameObject[] EnemysInLine => gameObjects;
        [SerializeField]
        private GameObject StartPoint;
        private GameObject[] gameObjects;
        [SerializeField]
        //private GameObject prefub;
        [Header("Spawn setings")]

        private Vector3 vectorDistanceReal = Vector3.zero;
        [SerializeField]
        private Vector3 vectorDistanceChange = new Vector3(0, -2f, 0);

        //private void Awake()
        //{
        //    Spawn(EnmemyOnline);


        //}
        private void Update()
        {
            EnemyShoose(gameObjects);
        }
        public void EnemyShoose(GameObject[] enemyes)
        {
            for (int i = enemyes.Length - 1; i > 0; i--)
            {
                if (enemyes[i] != null)
                {
                    enemyes[i].GetComponent<EnemyShoot>().ShootToPlayer();
                    break;
                }
            }
        }
        public void Spawn(int value, GameObject prefub)
        {
            gameObjects = new GameObject[value];
            for (int i = 0; i < value; i++)
            {
                gameObjects[i] = Instantiate(prefub, StartPoint.transform.position + vectorDistanceReal, Quaternion.identity);
                if(i==0)
                {
                    gameObjects[i].GetComponent<EnemyBase>().AddExtraHealth(gameObjects[i].GetComponent<EnemyBase>().live);
                }
                gameObjects[i].transform.parent = gameObject.transform;
                vectorDistanceReal += vectorDistanceChange;
            }
        }
    }
}


