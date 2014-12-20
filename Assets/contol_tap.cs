using UnityEngine;
using System.Collections;

public class contol_tap : MonoBehaviour {

	public float move_speed = 1F;

	private Vector3 tap_pos;
	private GameObject[] players;
	private int center;

	void Start() {
		center = 360;
		players = GameObject.FindGameObjectsWithTag("Player");
	}

	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			tap_pos = Input.mousePosition;

			Vector3 direction;

			if (tap_pos.x < center)
				direction = Vector3.up;
			else
				direction = -Vector3.up;

			foreach (GameObject player in players) {
				player.rigidbody2D.velocity = Vector3.zero;
				player.transform.position += direction * move_speed;
			}
		}
	}
}
