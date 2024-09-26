using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [field: SerializeField]
    public int Speed { get; private set; }
    [field: SerializeField]
    public int Power { get; private set; }


    private void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.y += 1 * Speed*Time.deltaTime;
        gameObject.transform.position = newPosition;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Oncoll");
        if(collision.gameObject.layer == 9) 
        {
            Debug.Log("Hit");
            collision.gameObject.GetComponent<Enemy>().TakeHit(Power);
        }
        Destroy(gameObject);
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
