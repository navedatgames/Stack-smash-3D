using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
	public Rigidbody rb;
	public float z;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(Input.GetKey(KeyCode.W))
		{
			rb.AddForce(0,0,z);
		FindObjectOfType<Score>().GetScore();
		}
    }
}
