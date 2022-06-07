using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartBtn : MonoBehaviour
{
    public void fRestart()
    {
        SceneManager.LoadScene("gameScene");
        Time.timeScale = 1;
        coinDestroyer.countercoin = 0;
    }

    public void fContinue()
    {
        SceneManager.LoadScene("gameScene2");
        Time.timeScale = 1;
    }

    public void fContinue2()
    {
        SceneManager.LoadScene("gameScene3");
        Time.timeScale = 1;
    }
}
