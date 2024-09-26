using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    //public int EnememyStealLive { get => _enmemyStealLive; set => _enmemyStealLive = value; }
    public GameObject[] EnemysInLine => gameObjects;
    [SerializeField]
    GameObject StartPoint;
    [SerializeField]
    int EnmemyOnline;
    //int _enmemyStealLive;
    private GameObject[] gameObjects;
    [SerializeField]
    GameObject prefub;
    [Header("Spawn setings")]

    Vector3 vectorDistanceReal =Vector3.zero;
    [SerializeField]
    Vector3 vectorDistanceChange = new Vector3(0, -2f,0);
    [SerializeField]
    EnemyShoot shoot;
    private void Awake()
    {
        Spawn(EnmemyOnline);
         shoot = new();
          
    }
    private void Update()
    {
        shoot.EnemyShoose(gameObjects);
    }
    public void Spawn(int value)
    {
        gameObjects = new GameObject[value];
        for (int i = 0; i < value; i++)
        {
            gameObjects[i] = Instantiate(prefub, StartPoint.transform.position + vectorDistanceReal, Quaternion.identity);
            gameObjects[i].transform.parent = gameObject.transform;
            vectorDistanceReal += vectorDistanceChange;
        }
    }
}
