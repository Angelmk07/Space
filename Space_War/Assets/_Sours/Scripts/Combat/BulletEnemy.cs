using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    [field: SerializeField]
    public int Speed { get; private set; }
    [field: SerializeField]
    public int Power { get; private set; }


    private void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.y += 1 * Speed * Time.deltaTime;
        gameObject.transform.position = newPosition;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.layer == 3)
        {
            collision.gameObject.GetComponent<Player>().TakeHit(Power);
            Destroy(gameObject);
        }

    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
