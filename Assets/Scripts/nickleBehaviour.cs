using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nickleBehaviour : MonoBehaviour
{
    public int rotationSpeed;

    float nicklePosY;

    int upCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nicklePosY = this.transform.position.y;

        transform.Rotate(0, rotationSpeed, 0);

        /*
        while (upCount < 2)
        {
            transform.position += new Vector3(0, 0.1f, 0);
            upCount++;
        }

        while (upCount > 2)
        {
            transform.position += new Vector3(0, -0.1f, 0);
            upCount--;
        }
        */


    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
    }

}
