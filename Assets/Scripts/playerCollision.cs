using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerCollision : MonoBehaviour
{
    public int nickleCount;
    public Text nickleCountUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.name == "DeathWall")
        {
            //Destroy(gameObject);
            transform.position = new Vector3(0, 0.6f, 0);
        }

        if (col.gameObject.name == "caida")
        {
            transform.position = new Vector3(0, 0.6f, 0);
        }

        if(col.gameObject.name == "nickle")
        {
            nickleCount++;
        }
    }
}
