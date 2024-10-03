using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Enemy.EMovment 
{
    public class EnemyMove
    {
        int index = 1;
        float _leftside = 8.7f;
        float _rightside = -8.7f;
        public void Move(GameObject[] gameObjects, float speed, Vector3 vectorMove)
        {
            for (int i = 0; i < gameObjects.Length; i++)
            {
                gameObjects[i].transform.position += vectorMove * index * speed * Time.deltaTime;
            }
            if (index == 1)
            {
                if (gameObjects[gameObjects.Length - 1].transform.position.x > _leftside)
                {
                    MoveDown(gameObjects);
                    index *= -1;
                }
            }
            else
            {
                if (gameObjects[0].transform.position.x < _rightside)
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
                gameObjects[i].transform.position += Vector3.down;
            }
        }
    }
}
