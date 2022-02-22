using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlatformControl : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag != "Mushroom" && other.gameObject.tag != "ChangeDirect"  && other.gameObject.tag != "IceItem")
        {  
            Score.score--;
            scoreText.text = Score.score.ToString();
        }
        Destroy(other.gameObject);
    }
}
