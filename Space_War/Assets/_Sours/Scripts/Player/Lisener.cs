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

    private void Start()
    {
        _invoker = new();
    }
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        _invoker.Move(player.gameObject, x, player.Speed);
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(player.Bullet, player.PlayerPosition);
            player.gameObject.GetComponent<Shoot>().Shooting(player.Bullet, player.PlayerPosition);
        }
    }
}
