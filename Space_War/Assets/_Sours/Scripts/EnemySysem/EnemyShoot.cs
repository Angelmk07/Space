using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyBullet;
    private Coroutine _coroutine;
    public void ShootToPlayer()
    {
                if (_coroutine == null)
                {
                    _coroutine = StartCoroutine(InitShoot());
                }
    }
    void EnemyShooting(GameObject prefub)
    {
        Instantiate(prefub,gameObject.transform.position,prefub.transform.rotation);
    }
    IEnumerator InitShoot()
    {
        yield return new WaitForSeconds(UnityEngine.Random.Range(1, 6));
        EnemyShooting(_enemyBullet);
        _coroutine = null;
    }
}
