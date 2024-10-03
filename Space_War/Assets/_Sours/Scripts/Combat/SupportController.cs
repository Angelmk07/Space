using Player.Shooting;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
namespace SupportToplayer.supportShip
{
    public class SupportController : MonoBehaviour
    {
        public static Action SupportDead;
        [SerializeField]
        private GameObject prefab;
        [SerializeField]
        private int live;
        private void OnEnable()
        {
            Shoot.PlayerDoShoot += ShootingSupport;
        }
        private void OnDisable()
        {
            Shoot.PlayerDoShoot -= ShootingSupport;
        }
        public void ShootingSupport()
        {
            if (gameObject != null)
            {
                Instantiate(prefab,
                gameObject.transform.position + new Vector3(0, 1f, 0),
                prefab.transform.rotation);
            }

        }

        public void Takehit(int value)
        {
            live -= value;
            if (live < 1)
            {
                Destroy(gameObject);
                SupportDead?.Invoke();
            }
        }

    }
}

