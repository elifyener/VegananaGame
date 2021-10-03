using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        animator.SetBool("isRight", false);
    }

    void Update()
    {
       if(Input.anyKey){
           if (Input.mousePosition.x < Screen.width / 2 && transform.position.x > -0.62f){
               transform.position = new Vector3(transform.position.x - 0.01f, transform.position.y, transform.position.z);
               transform.rotation = Quaternion.Euler(0f, 180f, 0f);
           }
           else if (Input.mousePosition.x > Screen.width / 2 && transform.position.x < 0.62f){
               transform.position = new Vector3(transform.position.x + 0.01f, transform.position.y, transform.position.z);
               transform.rotation = Quaternion.Euler(0f, 0f, 0f);
               
           }
           animator.SetBool("isRight", true);
       }
       else{
           animator.SetBool("isRight", false);
       }
    }
}

