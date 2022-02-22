using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Animator animator;
    public AudioClip pointSound;

    public static int score;
    bool animValue;
    TextMeshProUGUI scoreText;
    void Start()
    {
        scoreText = GameObject.Find("Canvas/scoreText").GetComponent<TextMeshProUGUI>();
    }
   private void OnTriggerEnter2D(Collider2D other) 
   {
       if(other.gameObject.tag != "Mushroom" && other.gameObject.tag != "ChangeDirect"  && other.gameObject.tag != "IceItem")
        {   
            score++;
            scoreText.text = score.ToString();
            AudioSource.PlayClipAtPoint(pointSound, transform.position,0.25f);
            animator.SetTrigger("catchTrigger");
            Destroy(other.gameObject);
        }
        else
        {
            animator.SetTrigger("catchTrigger");
            Destroy(other.gameObject);
        }
   }
}
