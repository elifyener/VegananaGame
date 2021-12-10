using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    public GameObject DeathScreen;
    public GameObject ScoreText;
    public GameObject pointText;
    public GameObject health1;
    public GameObject health2;
    public GameObject health3;

    public int health = 3;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        AudioListener.pause=false;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Mushroom")
        {
            health--;
            if(health <= 0)
            {
                health1.SetActive(false);
                Time.timeScale = 0;
                ScoreText.SetActive(false);
                DeathScreen.SetActive(true);
                AudioListener.pause=true;
                
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
