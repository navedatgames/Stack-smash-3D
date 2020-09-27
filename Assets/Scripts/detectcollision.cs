using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectcollision : MonoBehaviour
{
    private bool collided;
    private bool b = false;
    public Rigidbody rb;
    public float upforce ;
    public float downforce ;
    [Space]
    [Header("Sound")]
    [SerializeField] AudioSource jump;
    [SerializeField] AudioSource breakstack;
    [SerializeField] AudioSource gameover;
    public GameObject panel;

    private void OnCollisionEnter(Collision info)
    {
        collided = true;
           if(info.gameObject.tag=="base" && b == true)
           {
               rb.velocity = Vector3.down * downforce;
              Destroy(info.gameObject);
              breakstack.Play();
           } 
           else if(info.gameObject.tag=="base" && b == false)
           {
                rb.velocity = Vector3.up * upforce;
                jump.Play();
           }
    }
    private void OnTriggerEnter(Collider info)
    {
        if(info.tag=="over")
        {
             gameover.Play();
            panel.SetActive(true);
           
        }
    }

    private void OnCollisionExit(Collision info)
    {
       collided = false;
    }

    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            b = true;
            rb.velocity = Vector3.down * downforce;
            
            

        }
        else if(Input.GetButtonUp("Jump"))
        {
            b = false;
        }
    }
}
