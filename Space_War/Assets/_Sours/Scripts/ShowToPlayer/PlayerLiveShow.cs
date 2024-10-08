using Player.Player;
using Player.Resources;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Ui.ShowhealthPlayr
{
    public class PlayerLiveShow : MonoBehaviour
    {
        [SerializeField]
        private GameObject[] gameObjects;
        [SerializeField]
        private GameObject _livePrefub;
        [SerializeField]
        private GameObject PlayerObj;
        private int countlives;
        private void Awake()
        {
            gameObjects = new GameObject[PlayerObj.GetComponent<PlayerBase>().Live+PlayerResources.Instance.PlayerLivesAdd];
            for (int i = 0; i < gameObjects.Length; i++)
            {
                gameObjects[i] = Instantiate(_livePrefub, gameObject.transform);
            }

            countlives = gameObjects.Length - 1;
        }

        private void OnEnable()
        {
            PlayerBase.PlayerHit += LiveChange;
        }
        private void OnDisable()
        {
            PlayerBase.PlayerHit -= LiveChange;
        }
        private void LiveChange()
        {
            if (countlives < gameObjects.Length)
            {
                gameObjects[countlives].SetActive(false);
                countlives--;
            }

        }
    }
}

