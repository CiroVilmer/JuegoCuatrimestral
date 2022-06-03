using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideSpikeBehaviour : MonoBehaviour
{

    float xInicial;
    float xActual;
    float xFinal;
    float spikeSpeed = 0.03f;
    bool upFinished = false;

    void Start()
    {
        xInicial = this.transform.position.x;
        xFinal = xInicial - 1;
    }

    void Update()
    {
        xActual = this.transform.position.x;

        if (upFinished == false)
        {
            transform.Translate(-spikeSpeed, 0, 0);
        }

        if (xActual <= xFinal)
        {
            upFinished = true;
        }

        if(upFinished == true)
        {
            transform.Translate(spikeSpeed, 0, 0);
        }

        if(xActual >= xInicial+1)
        {
            upFinished = false;
        }
    }
}
