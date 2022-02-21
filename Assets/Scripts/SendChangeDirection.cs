using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendChangeDirection : MonoBehaviour
{
    [SerializeField] GameObject ChangeDirection;
    private void Start(){
            InvokeRepeating("CreateChangeDirect", 10f, 45f);
        }
    void CreateChangeDirect(){
        Instantiate(ChangeDirection, transform.position = new Vector2(Random.Range(-0.6f, 0.6f), transform.position.y), Quaternion.identity);
    }
}
