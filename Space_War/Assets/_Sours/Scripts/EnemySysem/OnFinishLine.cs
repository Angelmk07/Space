using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnFinishLine : MonoBehaviour
{

    [SerializeField]
    GameObject _player;
    [SerializeField]
    GameObject ScreenEnd;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            ScreenEnd.gameObject.SetActive(true);
            _player.GetComponent<Player>().TakeHit(_player.GetComponent<Player>().Live);

        }
    }

}
