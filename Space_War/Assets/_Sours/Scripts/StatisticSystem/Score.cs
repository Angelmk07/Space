using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI _Text;
    int _score = 0;
    public int PlayerScore => _score;
    [SerializeField]
    int _scoreAddValue = 100;
    public int Scor => _score;
    private void OnEnable()
    {
        Enemy.dead += ScoreAdd;
    }
    private void OnDisable()
    {
        Enemy.dead -= ScoreAdd;
    }
    void ScoreAdd()
    {
        _score +=_scoreAddValue;
        _Text.text = $"Your score {_score}"; 
    }
}
