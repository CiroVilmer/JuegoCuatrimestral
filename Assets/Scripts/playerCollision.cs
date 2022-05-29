using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerCollision : MonoBehaviour
{
    public int nickleCount;
    //public Text nickleCountUI;
    public Text textTime;
    float tiempo = 60;
    public Text gameOver;

    // Update is called once per frame
    void Update()
    {
        tiempo -= Time.deltaTime;
        textTime.text = tiempo.ToString("f0");

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
    }

    public void playerDeath()
    {
        Destroy(gameObject);
        
    }
}
