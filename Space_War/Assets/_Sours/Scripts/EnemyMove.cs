using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove
{
    int index = 1;

    public void Move(GameObject[] gameObjects, int speed, Vector3 vectorMove)
    {
        for (int i = 0; i < gameObjects.Length; i++)
        {
            gameObjects[i].transform.position += vectorMove * index * speed * Time.deltaTime;
        }
        if (index == 1)
        {
            if (gameObjects[gameObjects.Length - 2].transform.position.x > 8.7f)
            {
                MoveDown(gameObjects);
                index *= -1;
            }
        }
        else
        {
            if (gameObjects[0].transform.position.x < -8.7f)
            {
                MoveDown(gameObjects);
                index *= -1; 
            }
        }
    }

    void MoveDown(GameObject[] gameObjects)
    {
        for (int i = 0; i < gameObjects.Length; i++)
        {
            gameObjects[i].transform.position += Vector3.down * 2;
        }
    }
}