using Player.Resources;
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
        private bool imune = false;
        private SpriteRenderer _spriteRenderer;
        private void Awake()
        {
            PlayerPosition = gameObject;
            _isDead = false;
            Live += PlayerResources.Instance.PlayerLivesAdd;
            _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        }
        public void TakeHit(int value)
        {
            if (!imune)
            {
                Live -= value;
                PlayerHit?.Invoke();
                if (Live <= 0)
                {
                    _isDead = true;
                    PlayerDead?.Invoke();
                }
                imune = true;
                StartCoroutine(Imunemode());
            }


        }
        private IEnumerator Imunemode()
        {

            float blinkDuration = 0.2f;
            int blinkCount = 7;
            for (int i = 0; i < blinkCount; i++)
            {
                SetSpriteTransparency(0.5f);
                yield return new WaitForSeconds(blinkDuration);
                SetSpriteTransparency(1f);
                yield return new WaitForSeconds(blinkDuration);
            }
            imune = false; 
        }

        private void SetSpriteTransparency(float alpha)
        {
            if (_spriteRenderer != null)
            {
                Color newColor = _spriteRenderer.color;
                newColor.a = alpha;
                _spriteRenderer.color = newColor;
            }
        }
    }

}
