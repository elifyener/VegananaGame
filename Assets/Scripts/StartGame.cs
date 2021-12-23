using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        AudioListener.pause=false;
    }

    public void GameStart(){
        SceneManager.LoadScene(1);
    }
}
