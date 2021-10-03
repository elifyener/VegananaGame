using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendFruit : MonoBehaviour
{
    [SerializeField] GameObject[] Fruit = new GameObject[22];

    private void Start(){
        InvokeRepeating("CreateFruit", 0.5f, 1f);
    }

    void CreateFruit(){
        Instantiate(Fruit[Random.Range(0,22)], transform.position = new Vector2(Random.Range(-0.6f, 0.6f), transform.position.y), Quaternion.identity);
    }
}
