using Player.Player;
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
    private PlayerBase player;
    private Invoker _invoker;
    [SerializeField]
    private Stats _stats;
    private Shoot ScriptShoot;
    private void Start()
    {
        _invoker = new();
        ScriptShoot = player.gameObject.GetComponent<Shoot>();
    }
    void Update()
    {

        if (!_stats.GameStatusEnd)
        {
            x = Input.GetAxis("Horizontal");
            _invoker.Move(player.gameObject, x, player.Speed);
            if (Input.GetMouseButtonDown(0))
            {
                ScriptShoot.Shooting(player.Bullet, player.PlayerPosition);
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
