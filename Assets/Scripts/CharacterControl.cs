using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public Animator animator;
    private int direct = 1;
    private bool moving = true;
    public AudioClip IceSound;
    public AudioClip ChangeSound;
    void Start()
    {
        animator = GetComponent<Animator> ();
        animator.SetBool("isRight", false);
    }

    void Update()
    {
       if(Input.anyKey && moving){
           animator.SetBool("isRight", true);
           if ((direct * Input.mousePosition.x) < direct * (Screen.width) / 2 && transform.position.x > -0.62f){
               transform.position = new Vector3(transform.position.x - 0.015f, transform.position.y, transform.position.z);
               transform.rotation = Quaternion.Euler(0f, 180f, 0f);
           }
           else if ((direct * Input.mousePosition.x) > (direct * Screen.width / 2) && transform.position.x < 0.62f){
               transform.position = new Vector3(transform.position.x + 0.015f, transform.position.y, transform.position.z);
               transform.rotation = Quaternion.Euler(0f, 0f, 0f);
           }
           
       }
       else if(moving)
       {
            
            animator.SetBool("isRight", false);
       }
       else
       {
           animator.SetTrigger("freeze");
       }
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("ChangeDirect")){
            AudioSource.PlayClipAtPoint(ChangeSound, transform.position,3);
            direct *= -1;
        }
        if(other.gameObject.CompareTag("IceItem")){
            AudioSource.PlayClipAtPoint(IceSound, transform.position,3);
            Invoke ("DisableCollider", 0f);
            
            Invoke ("DefaultCollider", 3f);
           
        }
    }
    void  DisableCollider () 
    {
        GetComponent<Collider2D>().enabled = false;
        moving = false;

    }
    void DefaultCollider()
    {
        GetComponent<Collider2D>().enabled = true;
        moving = true;
    }
}

