using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowEnemyHp : MonoBehaviour
{
    [SerializeField]
    Enemy Enemy;
    private int maxHealth;
    private void Awake()
    {
        maxHealth = Enemy.live;
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
        float healthPercent = (float)Enemy.live / maxHealth; // Приведение к float для получения дробного значения

        if (healthPercent > 0.5f)
        {
            // Переход от жёлтого к зелёному
            float lerpValue = (healthPercent - 0.5f) * 2; // Диапазон от 0.5 до 1
            gameObject.GetComponent<SpriteRenderer>().color = Color.Lerp(Color.yellow, Color.green, lerpValue);
        }
        else
        {
            // Переход от красного к жёлтому
            float lerpValue = healthPercent * 2; // Диапазон от 0 до 0.5
            gameObject.GetComponent<SpriteRenderer>().color = Color.Lerp(Color.red, Color.yellow, lerpValue);
        }
    }
}
