using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void GameStart(){
        StartCoroutine(WaitForIt());
    }
    IEnumerator WaitForIt(){
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene(1);
    }
    
}
