using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeBehaviour : MonoBehaviour
{

    public float rateOfActivation = 1f;
    float fireRateDelta;
    bool upFinished = false;

    void Update()
    {
        while (upFinished == false)
        {
            if (transform.position.y < 3)
            {
                transform.position += new Vector3(0, 0.2f, 0);
                upFinished = true;
            }

        }

        while (upFinished == true)
        {
            if (transform.position.y > 3)
            {
                transform.position += new Vector3(0, -0.2f, 0);
                upFinished = false;
            }

        }


    }

    public void activate()
    {

        while (upFinished == false)
        {
            if(transform.position.y < 0)
            {
                transform.position += new Vector3(0, 0.2f, 0);
                upFinished = true;
            }
            
        }

        while (upFinished == true)
        {
            if (transform.position.y > 0)
            {
                transform.position += new Vector3(0, -0.2f, 0);
                upFinished = false;
            }
           
        }


    }

}
