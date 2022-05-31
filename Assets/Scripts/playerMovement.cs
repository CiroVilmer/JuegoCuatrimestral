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
    public static int trapLimit = 3;
    float trapRateDelta;
    public float trapRate = 1f;

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
               trapRateDelta -= Time.deltaTime;
                if (trapRateDelta <= 0)
                {
                    GameObject trapClon = Instantiate(trapPrefab, new Vector3(playerPosX, playerPosY, playerPosZ), Quaternion.identity);
                    Destroy(trapClon, 10);
                    trapLimit--;
                    trapRateDelta = trapRate;
                }
            }
        }

    }
}
