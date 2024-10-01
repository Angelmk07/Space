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
            spriteRenderer.color += new Color((1 - (1 / healthPercent)) * 2,
                spriteRenderer.color.g,
                spriteRenderer.color.b);

            spriteRenderer.color += new Color(1,
                spriteRenderer.color.g - 1 / healthPercent,
                spriteRenderer.color.b);

        }

    }
}

