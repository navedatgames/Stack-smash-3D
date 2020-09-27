using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public Text scoreText;
	float score = 0;
	// Start is called before the first frame update
    void Start()
    {
        
    }

	public void GetScore()
	{	score = score + 0.2f;
		scoreText.text = score.ToString("0");
	}
}
