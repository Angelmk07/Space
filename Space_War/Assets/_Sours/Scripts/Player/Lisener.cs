using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Lisener : MonoBehaviour
{
    [field:SerializeField]
    public float x { get;private set; }
    [field: SerializeField]
    public float z { get; private set; }
    [SerializeField]
    private Player player;
    private Invoker _invoker;
    [SerializeField]
    private Stats _stats;

    private void Start()
    {
        _invoker = new();
    }
    void Update()
    {

        if (!_stats.GameStatusEnd)
        {
            x = Input.GetAxis("Horizontal");
            _invoker.Move(player.gameObject, x, player.Speed);
            if (Input.GetMouseButtonDown(0))
            {
                player.gameObject.GetComponent<Shoot>().Shooting(player.Bullet, player.PlayerPosition);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("Game");
            }
        }


    }
}
