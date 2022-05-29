using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nickleBehaviour : MonoBehaviour
{
    public int rotationSpeed;

    float nicklePosY;

    void Update()
    {
        nicklePosY = this.transform.position.y;

        transform.Rotate(0, rotationSpeed, 0);

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            coinDestroyer.countercoin++;
            Destroy(gameObject);
        }
    }

}
