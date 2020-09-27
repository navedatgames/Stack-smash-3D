using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basemove : MonoBehaviour
{
	public float speed = 2f;
    

    void Update()
    {
		if((Input.GetAxis("Horizontal") > 0))
			{
				transform.Translate(2 * Time.deltaTime * speed,0,0);
			}
		else if((Input.GetAxis("Horizontal") < 0))
				{
					transform.Translate(-2 * Time.deltaTime * speed,0,0);
				}
        
    }
}
