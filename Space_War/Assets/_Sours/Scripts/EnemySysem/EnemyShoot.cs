using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyBullet;
    private Coroutine _coroutine;
    public void EnemyShoose(GameObject[] enemyes)
    {
        for(int i = enemyes.Length-1; i> 0; i--)
        {
           if(enemyes[i]!=null)
           {
                if (_coroutine == null)
                {
                    _coroutine = StartCoroutine(InitShoot());
                }
                
                break;
           }
        }
    }
    void EnemyShooting(GameObject prefub)
    {
        Instantiate(prefub);
    }
    IEnumerator InitShoot()
    {
        yield return new WaitForSeconds(UnityEngine.Random.Range(3, 5));
        EnemyShooting(_enemyBullet);
        _coroutine = null;
    }
}
