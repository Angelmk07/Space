using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SupportController : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;
    private void OnEnable()
    {
        Shoot.PlayerDoShoot += ShootingSupport;
    }
    private void OnDisable()
    {
        Shoot.PlayerDoShoot += ShootingSupport;
    }
    public void ShootingSupport()
    {
        if (gameObject!=null)
        {
            Instantiate(prefab,
            gameObject.transform.position + new Vector3(0, 1f, 0),
            prefab.transform.rotation);
        }

    }


}
