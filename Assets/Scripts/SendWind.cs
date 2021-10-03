using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendWind : MonoBehaviour
{
   [SerializeField] GameObject Wind;
    void Start()
    {
        InvokeRepeating("CreateWind", 1f, 0.5f);
    }

    void CreateWind(){
        Instantiate(Wind, transform.position = new Vector2(Random.Range(-0.5f, 0.5f), transform.position.y), Quaternion.identity);
    }
}
