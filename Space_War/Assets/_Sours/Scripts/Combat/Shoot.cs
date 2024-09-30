using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    private int maxShots = 3;
    [SerializeField]
    private float reloadTime = 2f; 
    private int currentShots = 0; 
    private bool isReloading = false;
    [SerializeField]
    private TextMeshProUGUI _AmmoText;
    public void Shooting(GameObject prefab, GameObject startPoint)
    {
        if (!isReloading)
        {
            if (currentShots < maxShots)
            {
                Instantiate(prefab,
                    startPoint.transform.position + new Vector3(0, 1f, 0),
                    prefab.transform.rotation);
                currentShots++;
            }
            _AmmoText.text = $"{currentShots}/{maxShots}";
            if (currentShots >= maxShots)
            {
                StartCoroutine(Reload()); 
            }
        }
    }
    private IEnumerator Reload()
    {
        _AmmoText.text = $"Reload";
        isReloading = true;
        yield return new WaitForSeconds(reloadTime);
        currentShots = 0; 
        isReloading = false;
        _AmmoText.text = $"{currentShots}/{maxShots}";
    }
}
