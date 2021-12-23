using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public Animator animator;
    private int direct = 1;

    void Start()
    {
        animator.SetBool("isRight", false);
    }

    void Update()
    {
       if(Input.anyKey){
           if ((direct * Input.mousePosition.x) < direct * (Screen.width) / 2 && transform.position.x > -0.62f){
               transform.position = new Vector3(transform.position.x - 0.015f, transform.position.y, transform.position.z);
               transform.rotation = Quaternion.Euler(0f, 180f, 0f);
           }
           else if ((direct * Input.mousePosition.x) > (direct * Screen.width / 2) && transform.position.x < 0.62f){
               transform.position = new Vector3(transform.position.x + 0.015f, transform.position.y, transform.position.z);
               transform.rotation = Quaternion.Euler(0f, 0f, 0f);
               
           }
           animator.SetBool("isRight", true);
       }
       else{
           animator.SetBool("isRight", false);
       }
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("ChangeDirect")){
            direct *= -1;
        }
    }
}

