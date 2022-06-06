using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerCollision : MonoBehaviour
{
    public int nickleCount;
    public Text textTime;
    public GameObject restartBTN;
    public GameObject continueBTN;
    float tiempo = 60;
    public Text gameOver;
    bool keyOnPlayer = false;
    public int cheeseTime = 10;
    public Text txtWarnings;
    Vector3 spawn;
    public Text txtVida;
    public float vida = 3;


    void Start()
    {

        gameOver.enabled = false;
        spawn = this.transform.position;
        Time.timeScale = 1;
    }
    
    void Update()
    {
        tiempo -= Time.deltaTime;

        txtVida.text = "Vidas restantes:"+ vida;

        if(tiempo < 0)
        {
            GameOver();
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
                gameOver.text = "Ganaste!!!";
                continueBTN.SetActive(true);
                playerDeath();
            }
            else
            {
                txtWarnings.text = "No tenes la llave";
            }
        }

        if(keyOnPlayer == true)
        {
            txtWarnings.text = "Tenes la llave!";
        }

        if(col.gameObject.name == "cheese")
        {
            tiempo += cheeseTime;
        }

        if(col.gameObject.name == "manzana(Clone)")
        {
            playerDeath();
        }

        if(col.gameObject.name == "spike")
        {
            playerDeath();
        }

        if (vida == 0)
        {
            GameOver();
        }

    }

    public void playerDeath()
    {
        transform.position = spawn;
        vida--;
     //   Destroy(gameObject);
        
    }

    public void GameOver()
    {
        restartBTN.SetActive(true);
        gameOver.enabled = true;
        Time.timeScale = 0;
    }
}
