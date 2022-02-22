using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public AudioSource pauseSound;
    public AudioSource BgSound;
    static bool flag = true;
    public GameObject PauseScreen;
    public GameObject ScoreText;
    void Start()
    {
        //AudioListener.pause=false;
    }

    public void PauseGame(){
        Time.timeScale = 0;
        CharacterControl.moving = false;
        ScoreText.SetActive(false);
        BgSound.Pause();
        pauseSound.Play();
        PauseScreen.SetActive(true);
    }
    public void ResumeGame(){
        CharacterControl.moving = true;
        PauseScreen.SetActive(false);
        ScoreText.SetActive(true);
        BgSound.Play();
        pauseSound.Stop();
        Time.timeScale = 1;
    }
    public void OffOnMusic(){
        AudioListener.pause=flag;
        flag = !flag;
    }
    public void RestartGame(){
        Score.score = 0;
        CharacterControl.moving = true;
        SceneManager.LoadScene(1);
    }
    public void GotoMainMenu(){
        Score.score = 0;
        CharacterControl.moving = true;
        SceneManager.LoadScene(0);
    }
    
}
