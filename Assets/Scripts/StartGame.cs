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
        StartCoroutine(WaitForIt());
    }
    IEnumerator WaitForIt(){
        yield return new WaitForSecondsRealtime(0.05f);
        SceneManager.LoadScene(1);
    }
    
}
