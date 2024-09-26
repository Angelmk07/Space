using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField]
    GameObject StartPoint;
    [SerializeField]
    int EnmemyOnline;
    GameObject[] gameObjects;
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
    public void Spawn(int value)
    {
        gameObjects = new GameObject[value];
        for (int i = 0; i < value; i++)
        {
            gameObjects[i] = Instantiate(prefub, StartPoint.transform.position + vectorDistanceReal, Quaternion.identity);
            vectorDistanceReal += vectorDistanceChange;
        }
    }
}
