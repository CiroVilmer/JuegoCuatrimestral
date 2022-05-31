using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    float rateOfFire = 1f;
    float fireRateDelta;

    void Update()
    {
        fireRateDelta -= Time.deltaTime;
        if (fireRateDelta <= 0)
        {
            Fire();
            fireRateDelta = rateOfFire;
        }
        
    }

    public void Fire()
    {
        GameObject clon;
        clon = Instantiate(bulletPrefab, transform.position, transform.rotation);
        Destroy(clon, 6);
    }

}
