using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // for scene and restart button
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject player; //to set player in inspector for play, restart button
    public static bool isGameStarted;

    //public void PlayButton()
    //{
    //    player.SetActive(true); //to stop playermovement before pressing play button
    //}

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  //to load the scene again
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
