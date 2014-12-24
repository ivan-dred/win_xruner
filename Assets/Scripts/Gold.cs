using UnityEngine;
using System.Collections;

public class Gold : MonoBehaviour {

	HUDscript hud;

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
			hud = GameObject.Find("Main Camera").GetComponent<HUDscript>();
			hud.IncreaseScore(10);
			Destroy (this.gameObject);
		}
	}

}
