using Player.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game.GameEnd
{
    public class OnFinishLine : MonoBehaviour
    {

        [SerializeField]
        private GameObject _player;
        private PlayerBase ScriptPlayer;
        [SerializeField]
        private GameObject ScreenEnd;
        [SerializeField]
        private LayerMask Layer;
        private void Start()
        {
            ScriptPlayer = _player.GetComponent<PlayerBase>();
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (Utils.LayerMaskUtil.ContainsLayer(Layer, collision.gameObject))
            {
                ScreenEnd.gameObject.SetActive(true);
                ScriptPlayer.TakeHit(ScriptPlayer.Live);

            }
        }

    }
}

