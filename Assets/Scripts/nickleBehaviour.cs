using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nickleBehaviour : MonoBehaviour
{
    public int rotationSpeed;

    float nicklePosY;

    public GameObject coinSound;

    void Update()
    {
        nicklePosY = this.transform.position.y;

        if(Time.timeScale == 1)
        {
            transform.Rotate(0, rotationSpeed, 0);
        }

        

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            coinDestroyer.countercoin++;
            Destroy(gameObject);

            GameObject clon = Instantiate(coinSound);
            Destroy(clon, 3);

        }
    }

}
