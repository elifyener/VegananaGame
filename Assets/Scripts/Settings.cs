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
        PauseScreen.SetActive(false);
        AudioListener.pause=false;
        Time.timeScale = 1;
    }
    public void OffOnMusic(){
        AudioListener.pause=flag;
        flag = !flag;
    }
    public void RestartGame(){
        SceneManager.LoadScene(1);
    }
    public void GotoMainMenu(){
        SceneManager.LoadScene(0);
    }
    
}
