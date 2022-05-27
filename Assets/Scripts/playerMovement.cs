using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;
    public GameObject trapPrefab;
    float playerPosX;
    float playerPosY;
    float playerPosZ;
    public int trapLimit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPosX = this.transform.position.x;
        playerPosY = this.transform.position.y;
        playerPosZ = this.transform.position.z;

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, movementSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -movementSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationSpeed, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotationSpeed, 0);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            while (trapLimit > 0)
            {
                GameObject trapClon = Instantiate(trapPrefab, new Vector3(playerPosX, 0.5f, playerPosZ), Quaternion.identity);
                Destroy(trapClon, 10);
                trapLimit--;
            }
            
        }

    }
}
