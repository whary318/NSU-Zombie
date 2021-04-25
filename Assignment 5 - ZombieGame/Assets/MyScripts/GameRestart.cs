using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRestart : MonoBehaviour
{

    public GameObject restartHUD;
    public GameObject winHUD;


    void Start()
    {
        restartHUD.SetActive(false);
    }

    public void restartGame()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        Time.timeScale = 1.0f;
    }

    public void GameOver()
    {
        Time.timeScale = 0.0f;
        restartHUD.SetActive(true);
    }

    public void winGame()
    {
        Time.timeScale = 0.0f;
        winHUD.SetActive(true);
    }
}
