using UnityEngine;
using System.Collections;

public class ghost : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
//		transform.position.x = transform.position.x + 100;
		transform.position += Vector3.right * 0.1F;
	}

	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
//			Debug.Log ("Player - ghost");
			Debug.Break();
			return;
		}
	}

}
