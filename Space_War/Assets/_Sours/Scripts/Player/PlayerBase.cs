using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Player.Player 
{
    public class PlayerBase : MonoBehaviour
    {
        public static Action PlayerDead;
        public static Action PlayerHit;
        [field: SerializeField]
        public int Speed { get; private set; }
        [field: SerializeField]
        public int Live { get; private set; }
        [field: SerializeField]
        public GameObject Bullet { get; private set; }
        public bool _isDead { get; private set; }
        public GameObject PlayerPosition { get; private set; }
        private void Awake()
        {
            PlayerPosition = gameObject;
            _isDead = false;
        }
        public void TakeHit(int value)
        {
            Live -= value;
            PlayerHit?.Invoke();
            if (Live <= 0)
            {
                _isDead = true;
                PlayerDead?.Invoke();
            }
        }
    }

}
