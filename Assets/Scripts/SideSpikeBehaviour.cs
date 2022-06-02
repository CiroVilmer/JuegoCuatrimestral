using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideSpikeBehaviour : MonoBehaviour
{

    float x;
    float UpSpikeSpeed = 0.03f;
    float DownSpikeSpeed = 0.02f;
    bool upFinished = false;

    void Update()
    {

        x = this.transform.position.x;

        if (x >= x+1)
        {
            upFinished = true;
        }
        if (x <= -x+5)
        {
            upFinished = false;
        }

        if (upFinished == false)
        {
            transform.position += new Vector3(-UpSpikeSpeed, 0, 0);
        }

        if (upFinished == true)
        {
            transform.position += new Vector3(DownSpikeSpeed, 0, 0);
        }

    }
}
