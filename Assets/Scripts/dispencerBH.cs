using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dispencerBH : MonoBehaviour
{
    public GameObject itemPrefab;
    float rateOfFire = 1f;
    float fireRateDelta;

    void Update()
    {
        fireRateDelta -= Time.deltaTime;
        if (fireRateDelta <= 0)
        {
            activate();
            fireRateDelta = rateOfFire;
        }

    }

    public void activate()
    {
        GameObject clon;
        clon = Instantiate(itemPrefab, transform.position, transform.rotation);
        Destroy(clon, 6);
    }

}
