using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class Lisener : MonoBehaviour
{
    [field:SerializeField]
    public float x { get;private set; }
    [field: SerializeField]
    public float z { get; private set; }
    [SerializeField]
    private Player player;
    private Invoker _invoker;
    private bool Restart;

    private void Start()
    {
        _invoker = new();
    }
    void Update()
    {

        if (!player._isDead)
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
                Restart = true;
            }
        }


    }
}
