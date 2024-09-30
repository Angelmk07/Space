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

    }
    private void OnEnable()
    {
        Enemy.dead += DeadsAdd;
        Player.PlayerDead += ShowEndScreen;
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
        Enemy.dead -= DeadsAdd;
        Player.PlayerDead -= ShowEndScreen;
        EnemyAction.Win -= WinText;
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
    }

}
