using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    int EnemyVerticalLinsSet;
    int EnemyHorizontalSet;
    int EnemySpeed;
    int EnemyLive;
    int bullets;
    int reloadTime;

}