using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Retry : MonoBehaviour {

    // Use this for initialization
    public void PlayGame()
    {
        Application.LoadLevel("Level_1");
        Lives.lives = 3;
        Score.score = 0;
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
