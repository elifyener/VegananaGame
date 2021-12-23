using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendMushroom : MonoBehaviour
{
    [SerializeField] GameObject Mushroom;

    private void Start(){
            InvokeRepeating("CreateMushroom", 1f, 2.11f);
        }
    void CreateMushroom(){
        Instantiate(Mushroom, transform.position = new Vector2(Random.Range(-0.6f, 0.6f), transform.position.y), Quaternion.identity);
    }
}
