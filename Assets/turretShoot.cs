using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    float tiempo = 0;

    // Start is called before the first frame update
    void Start()
    {
        tiempo += Time.deltaTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject clon;

        
        clon = Instantiate(bulletPrefab);

        Destroy(clon, 4);

        clon.transform.position = transform.position;

       
        
        
    }


}
