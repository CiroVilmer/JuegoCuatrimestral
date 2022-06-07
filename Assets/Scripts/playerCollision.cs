using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerCollision : MonoBehaviour
{
    public static int nickleCount;
    public Text textTime;
    public GameObject restartBTN;
    public GameObject continueBTN;
    public float tiempo = 60;
    public Text gameOver;
    bool keyOnPlayer = false;
    public int cheeseTime = 10;
    public Text txtWarnings;
    Vector3 spawn;
    public Text txtVida;
    public float vida = 3;
    public GameObject bridgePrefab;
    bool lvl1 = true;


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
                Time.timeScale = 0;
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

        if(col.gameObject.name == "plate")
        {
            if(nickleCount >= 4)
            {
                for (int i = 0; i < 10; i++)
                {
                  
                    Instantiate(bridgePrefab, new Vector3(0, 0, -12 - i), Quaternion.identity);
                }
            }
            else
            {
                txtWarnings.text = "NECESITAS 4 MONEDAS PARA ACTIVAR EL PUENTE";
            }
        }
    }

    public void playerDeath()
    {
        if(vida == 1)
        {
            GameOver();
        }
        else
        {
            transform.position = spawn;
            vida--;
        }
        
    }

    public void GameOver()
    {
        restartBTN.SetActive(true);
        gameOver.enabled = true;
        Time.timeScale = 0;
    }
}
