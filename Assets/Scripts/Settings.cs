using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public AudioClip pauseSound;
    bool flag = true;
    public GameObject PauseScreen;
    void Start()
    {
        AudioListener.pause=false;
    }

    public void PauseGame(){
        Time.timeScale = 0;
        AudioListener.pause=true;
        AudioSource.PlayClipAtPoint(pauseSound, transform.position,1);
        PauseScreen.SetActive(true);
    }
    public void ResumeGame(){
        StartCoroutine(WaitForIt());
    }
    public void OffOnMusic(){
        AudioListener.pause=flag;
        flag = !flag;
    }
    IEnumerator WaitForIt(){
        yield return new WaitForSecondsRealtime(0.05f);
        PauseScreen.SetActive(false);
        AudioListener.pause=false;
        Time.timeScale = 1;
    }
    public void RestartGame(){
        StartCoroutine(WaitForRestart());
    }
    public void GotoMainMenu(){
        StartCoroutine(WaitForMainMenu());
    }
    IEnumerator WaitForRestart(){
        yield return new WaitForSecondsRealtime(0.05f);
        AudioListener.pause=false;
        SceneManager.LoadScene(1);
    }
    IEnumerator WaitForMainMenu(){
        yield return new WaitForSecondsRealtime(0.05f);
        AudioListener.pause=false;
        SceneManager.LoadScene(0);
    }
}
