using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendFruit : MonoBehaviour
{
    [SerializeField] GameObject[] Fruit = new GameObject[21];
    

    private void Start(){
        InvokeRepeating("CreateFruit", 0.5f, 0.53f);
    }

    void CreateFruit(){
        Instantiate(Fruit[Random.Range(0,21)], transform.position = new Vector2(Random.Range(-0.6f, 0.6f), transform.position.y), Quaternion.identity);
    }
    
}
