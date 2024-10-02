using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerResources : MonoBehaviour
{
    public static PlayerResources Instance { get; private set; }
    public static Action<int> BoughtEvent;
    private int score=0;
    private int PlayerSpeedRelad=0;
    private int PlayerBullets = 0;
    private int CountOfReinforsments = 0;

    public int Score
    {
        get { return score; }
        set { score = value; }
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);  
        }
        else
        {
            Destroy(gameObject);  
        }
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void AddScore(int points)
    {
        score += points;
    }
    public void Bought(int points)
    {
        score -= points;
        BoughtEvent?.Invoke(score);
    }
    public int Return()
    {
        return score;
    }
}
