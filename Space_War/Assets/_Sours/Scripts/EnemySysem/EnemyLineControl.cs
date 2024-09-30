using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLineControl : MonoBehaviour
{
    public int EnememyLive=> EnmemyOnline;
    public GameObject[] EnemysInLine => gameObjects;
    [SerializeField]
    GameObject StartPoint;
    [SerializeField]
    int EnmemyOnline;
    private GameObject[] gameObjects;
    [SerializeField]
    GameObject prefub;
    [Header("Spawn setings")]

    Vector3 vectorDistanceReal =Vector3.zero;
    [SerializeField]
    Vector3 vectorDistanceChange = new Vector3(0, -2f,0);

    private void Awake()
    {
        Spawn(EnmemyOnline);

          
    }
    private void Update()
    {
        EnemyShoose( gameObjects);
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
