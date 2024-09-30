using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowEnemyHp : MonoBehaviour
{
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
        throw new NotImplementedException();
    }
}
