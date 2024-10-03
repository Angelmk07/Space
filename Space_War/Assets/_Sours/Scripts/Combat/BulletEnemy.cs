using Player.Player;
using SupportToplayer.supportShip;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Enemy.EBullet
{
    public class BulletEnemy : MonoBehaviour
    {
        [field: SerializeField]
        public int Speed { get; private set; }
        [field: SerializeField]
        public int Power { get; private set; }
        [SerializeField]
        private LayerMask Player;
        [SerializeField]
        private LayerMask Supports;

        private void Update()
        {
            Vector3 newPosition = transform.position;
            newPosition.y += 1 * Speed * Time.deltaTime;
            gameObject.transform.position = newPosition;
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {

            if (Utils.LayerMaskUtil.ContainsLayer(Player, collision.gameObject))
            {
                collision.gameObject.GetComponent<PlayerBase>().TakeHit(Power);
                Destroy(gameObject);
            }
            else if (Utils.LayerMaskUtil.ContainsLayer(Supports, collision.gameObject))
            {
                collision.gameObject.GetComponent<SupportController>().Takehit(Power);
                Destroy(gameObject);
            }

        }

        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    }

}
