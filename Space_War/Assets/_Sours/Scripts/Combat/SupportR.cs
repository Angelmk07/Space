using Player.Resources;
using SupportToplayer.supportShip;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SupportToplayer.SpawnShips
{
    public class SupportR : MonoBehaviour
    {
        [SerializeField]
        private GameObject[] supportPoints;
        [SerializeField]
        private GameObject prefubSuppor;
        private bool isactive = false;
        private int SupporstStillAlive;
        private void Start()
        {
            SupporstStillAlive = supportPoints.Length;
        }
        private void OnEnable()
        {
            SupportController.SupportDead += casualties;
        }


        private void OnDisable()
        {
            SupportController.SupportDead += casualties;
        }

        public void SpawnSupport()
        {
            Debug.Log("SpawnSupportStart");
            if (PlayerResources.Instance.CountOfReinforsments >= 1 && !isactive)
            {
                isactive = true;
                PlayerResources.Instance.CountOfReinforsments -= 1;
                for (int i = 0; i < supportPoints.Length; i++)
                {
                    Instantiate(prefubSuppor,
                    supportPoints[i].transform);


                }
                Debug.Log("SpawnSupportEnd");
            }

        }
        private void casualties()
        {
            SupporstStillAlive--;
            if (SupporstStillAlive < 1)
            {
                isactive = false;
            }
        }

    }

}
