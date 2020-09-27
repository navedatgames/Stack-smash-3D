using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spheremovement : MonoBehaviour
{
	public Rigidbody rb;
	public float force;
	public bool enable;
	
	
	void OnCollisionEnter(Collision info)
	{
		if(enable)
		{
			if(info.collider.tag=="base")
			{	
				rb.velocity = Vector3.up * force;
			}
		}
	}
	
}
