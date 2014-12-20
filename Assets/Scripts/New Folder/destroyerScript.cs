﻿using UnityEngine;
using System.Collections;

public class destroyerScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
			//Application.LoadLevel(1);
			//return;
			Debug.Break ();
			return;
		}
		if (other.gameObject.transform.parent) 
		{
			Destroy (other.gameObject.transform.parent.gameObject);
		}
		else
		{
			Destroy (other.gameObject);
		}
	}
}