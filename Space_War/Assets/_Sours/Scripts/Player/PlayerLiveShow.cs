using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLiveShow : MonoBehaviour
{
    [SerializeField]
    GameObject[] gameObjects;
    [SerializeField]
    GameObject _livePrefub;
    [SerializeField]
    GameObject PlayerObj;
    int countlives;
    private void Awake()
    {
        gameObjects = new GameObject[PlayerObj.GetComponent<Player>().Live];
        for (int i=0;i< PlayerObj.GetComponent<Player>().Live; i++)
        {
            gameObjects[i] =Instantiate(_livePrefub, gameObject.transform);
        }

        countlives = gameObjects.Length-1;
    }
    
    private void OnEnable()
    {
        Player.PlayerHit += LiveChange;
    }
    private void OnDisable()
    {
        Player.PlayerHit -= LiveChange;
    }
    private void LiveChange()
    {
        gameObjects[countlives].SetActive(false);
        countlives--;
    }
}
