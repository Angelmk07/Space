using Enemy.Enemy;
using Enemy.EnemyHorizontalLine;
using Game.GameEnd;
using Player.Player;
using Player.Resources;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI _Text;
    [SerializeField]
    TextMeshProUGUI _TextEndOfPlay;
    [SerializeField]
    GameObject Screen;
    [SerializeField]
    Score _score;
    [SerializeField]
    Image _image;
    int _kills =0;

    public bool GameStatusEnd { get; private set; }
    private void Awake()
    {
        GameStatusEnd = false;
    }
    private void OnEnable()
    {
        EnemyBase.dead += DeadsAdd;
        PlayerBase.PlayerDead += ShowEndScreen;
        OnFinishLine.PlayerLose += ShowEndScreen;
        EnemyAction.Win += WinText;
    }

    private void WinText()
    {
        ShowEndScreen();
        var imagewin = Resources.Load<Sprite>("PlayerWin");
        _image.sprite = imagewin;
        _TextEndOfPlay.text = "You Win";

    }

    private void OnDisable()
    {
        EnemyBase.dead -= DeadsAdd;
        PlayerBase.PlayerDead -= ShowEndScreen;
        EnemyAction.Win -= WinText;
        OnFinishLine.PlayerLose -= ShowEndScreen;
    }
    void DeadsAdd()
    {
        _kills++;
        
        
    }

    private void ShowEndScreen()
    {
        Screen.SetActive(true);
        _Text.text = $"Your Score {_score.PlayerScore}, kills {_kills}";
        GameStatusEnd = true;
        PlayerResources.Instance.AddScore(_score.PlayerScore);

    }

}
