using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeBehaviour : MonoBehaviour
{

    float y;
    float UpSpikeSpeed = 0.03f;
    float DownSpikeSpeed = 0.02f;
    bool upFinished = false;

    void Update()
    {

        y = this.transform.position.y;

        if(y >= 0.2f)
        {
            upFinished = true;
        }
        if(y <= -1.5f)
        {
            upFinished = false;
        }

        if(upFinished == false)
        {
            transform.Translate(0, UpSpikeSpeed, 0);
        }

        if (upFinished == true)
        {
            transform.Translate(0, -DownSpikeSpeed, 0);
        }

    }

}
