using Enemy.Enemy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Player.PlayerBullet 
{
    public class Bullet : MonoBehaviour
    {
        [field: SerializeField]
        public int Speed { get; private set; }
        [field: SerializeField]
        public int Power { get; private set; }
        [SerializeField]
        private LayerMask layerMask;
  

        private void Update()
        {
            Vector3 newPosition = transform.position;
            newPosition.y += 1 * Speed * Time.deltaTime;
            gameObject.transform.position = newPosition;
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (Utils.LayerMaskUtil.ContainsLayer(layerMask, collision.gameObject))
            {
                collision.gameObject.GetComponent<EnemyBase>().TakeHit(Power);
            }
            Destroy(gameObject);
        }
        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    }

}
