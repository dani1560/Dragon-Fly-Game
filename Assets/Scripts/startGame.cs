using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void ReStart()
    {
        SceneManager.LoadScene("Start");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
