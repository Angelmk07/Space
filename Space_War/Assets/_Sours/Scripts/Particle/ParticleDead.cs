using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDead : MonoBehaviour
{
    private void Awake()
    {
        Destroy(gameObject, gameObject.GetComponent<ParticleSystem>().duration);
    }
}
