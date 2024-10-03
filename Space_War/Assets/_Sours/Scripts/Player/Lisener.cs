using Player.Player;
using Player.Shooting;
using SupportToplayer.SpawnShips;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Player.LisenButtuns
{
    public class Lisener : MonoBehaviour
{
    [field:SerializeField]
    public float x { get;private set; }
    [field: SerializeField]
    public float z { get; private set; }
    [SerializeField]
    private SupportR _supportR;
    [SerializeField]
    private PlayerBase _player;
    private Invoker _invoker;
    [SerializeField]
    private Stats _stats;
    private Shoot _scriptShoot;

    private void Start()
    {
        _invoker = new();
        _scriptShoot = _player.gameObject.GetComponent<Shoot>();

    }
    void Update()
    {

        if (!_stats.GameStatusEnd)
        {
            x = Input.GetAxis("Horizontal");
            _invoker.Move(_player.gameObject, x, _player.Speed);
            if (Input.GetMouseButtonDown(0))
            {
                _scriptShoot.Shooting(_player.Bullet, _player.PlayerPosition);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _supportR.SpawnSupport();
                Debug.Log("SpawnSupport");
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            if (Input.GetKeyDown(KeyCode.CapsLock))
            {
                SceneManager.LoadScene("Start");
            }
        }
    }
}

}
