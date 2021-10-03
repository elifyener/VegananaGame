using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendCloud : MonoBehaviour
{
    [SerializeField] GameObject[] Cloud = new GameObject[7];
    void Start()
    {
        InvokeRepeating("CreateCloud", 0.5f, 3f);
    }

    void CreateCloud(){
        Instantiate(Cloud[Random.Range(0,7)], transform.position = new Vector2(Random.Range(-0.85f, 0.85f), transform.position.y), Quaternion.identity);
    }
}
