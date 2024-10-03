using Player.Player;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game.GameEnd
{
    public class OnFinishLine : MonoBehaviour
    {
        public static Action PlayerLose; 
        [SerializeField]
        private LayerMask Layer;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (Utils.LayerMaskUtil.ContainsLayer(Layer, collision.gameObject))
            {
                PlayerLose?.Invoke();
            }
        }
    }
}

