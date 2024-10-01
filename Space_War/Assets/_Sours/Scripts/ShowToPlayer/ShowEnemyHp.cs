using Enemy.Enemy;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Ui.ShowhealthEnemy
{
    public class ShowEnemyHp : MonoBehaviour
    {
        [SerializeField]
        private EnemyBase Enemy;
        private int maxHealth;
        private SpriteRenderer spriteRenderer;
        private void Awake()
        {
            maxHealth = Enemy.live;
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        private void OnEnable()
        {
            Enemy.Hit += ChangeImage;
        }
        private void OnDisable()
        {
            Enemy.Hit -= ChangeImage;
        }
        private void ChangeImage()
        {
            float healthPercent = (float)Enemy.live / maxHealth;

            spriteRenderer.color = new Color(1, Mathf.Clamp01(healthPercent * 1.2f), 0);

        }

    }
}

