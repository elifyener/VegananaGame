using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    public GameObject ScoreText;
    public GameObject health1;
    public GameObject health2;
    public GameObject health3;
    public int health = 3;
    public AudioSource pauseSound;
    public AudioSource BgSound;
    public AudioClip MushroomSound;
    public GameObject DeathScreen;
    [SerializeField] TextMeshProUGUI game_score;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Mushroom")
        {
            AudioSource.PlayClipAtPoint(MushroomSound, transform.position,3);
            health--;
            if(health <= 0)
            {
                health1.SetActive(false);
                ScoreText.SetActive(false);
                game_score.text = Score.score.ToString();
                Time.timeScale = 0;
                BgSound.Stop();
                pauseSound.Play();
                CharacterControl.moving = false;
                DeathScreen.SetActive(true);
            }
            if (health<=2)
            {
                health3.SetActive(false);
            }
            if (health<=1)
            {
                health2.SetActive(false);
            }
        }
    }

}
