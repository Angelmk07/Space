using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace Enemy.Enemy 
{
    public class EnemyBase : MonoBehaviour
    {
        public static Action dead;
        public Action Hit;
        [field: SerializeField]
        public int live { get; private set; }
        [SerializeField]
        private ParticleSystem particle;
        [SerializeField]
        private int power;
        public int Power => power;
        //public int Live { get => live; set => live = value; }

        public void TakeHit(int value)
        {
            live -= value;
            Hit?.Invoke();
            if (live < 1)
            {
                dead?.Invoke();
                Instantiate(particle, gameObject.transform.position, Quaternion.identity).GetComponent<ParticleSystem>().Play();
                Destroy(gameObject);
            }
        }

    }

}

