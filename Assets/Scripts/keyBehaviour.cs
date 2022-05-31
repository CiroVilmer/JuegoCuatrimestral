using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyBehaviour : MonoBehaviour
{
    public float rotationSpeed;

    float keyPosY;

    void Update()
    {
        keyPosY = this.transform.position.y;

        transform.Rotate(0, rotationSpeed, 0);

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
    }

}
