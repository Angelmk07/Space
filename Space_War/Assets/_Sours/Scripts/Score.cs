using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI _Text;
    int _score = 0;
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
        _score++;
        _Text.text = $"Your score {_score}"; 
    }
}
