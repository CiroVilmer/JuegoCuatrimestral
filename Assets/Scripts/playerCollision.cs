using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerCollision : MonoBehaviour
{
    public int nickleCount;
    public Text textTime;
    float tiempo = 60;
    public Text gameOver;
    bool keyOnPlayer = false;
    public Text levelComplete;
    public int cheeseTime = 10;
    public Text txtWarnings;

    void Start()
    {
        gameOver.enabled = false;
        levelComplete.enabled = false;
    }
    
    void Update()
    {
        tiempo -= Time.deltaTime;

        if(tiempo < 0)
        {
            playerDeath();
        }
        else
        {
            textTime.text = tiempo.ToString("f0");
        }
    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.name == "DeathWall")
        {
            playerDeath();
        }

        if (col.gameObject.name == "caida")
        {
            transform.position = new Vector3(0, 0.6f, 0);
        }

        if(col.gameObject.name == "nickle")
        {
            nickleCount++;
            
        }

        if(col.gameObject.name == "bulletPrefab(Clone)")
        {
            playerDeath();
        }

        if(col.gameObject.name == "uper")
        {
            playerMovement.trapLimit++;
        }

        if(col.gameObject.name == "Trap")
        {
            playerDeath();
        }

        if(col.gameObject.name == "key")
        {
            keyOnPlayer = true;
        }

        if(col.gameObject.name == "Door")
        {
            if(keyOnPlayer == true)
            {
                levelComplete.enabled = true;
                playerDeath();
            }
            else
            {
                txtWarnings.text = "No tenes la llave";
            }
        }

        if(col.gameObject.name == "cheese")
        {
            tiempo += cheeseTime;
        }

        if(col.gameObject.name == "manzana(Clone)")
        {
            playerDeath();
        }
    }

    public void playerDeath()
    {
        Destroy(gameObject);
        gameOver.enabled = true;
    }
}
