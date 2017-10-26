using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipScript : MonoBehaviour {

	public GameObject Player1 = null;
	public GameObject Player2 = null;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.name == "Player 1") {
			if (Player1.GetComponent<PlayerController> ().isFlipped == false)
			{
				Player1.GetComponent<PlayerController> ().isFlipped = true;
				Player1.GetComponent<PlayerController> ().upInput = KeyCode.S;
				Player1.GetComponent<PlayerController> ().downInput = KeyCode.W;
				Player1.GetComponent<PlayerController> ().leftInput = KeyCode.D;
				Player1.GetComponent<PlayerController> ().rightInput = KeyCode.A;
			}
			else if (Player1.GetComponent<PlayerController> ().isFlipped == true)
			{
				Player1.GetComponent<PlayerController> ().isFlipped = false;
				Player1.GetComponent<PlayerController> ().upInput = KeyCode.W;
				Player1.GetComponent<PlayerController> ().downInput = KeyCode.S;
				Player1.GetComponent<PlayerController> ().leftInput = KeyCode.A;
				Player1.GetComponent<PlayerController> ().rightInput = KeyCode.D;
			}
		}

		if (other.gameObject.name == "Player 2") {
			if (Player2.GetComponent<PlayerController> ().isFlipped == false)
			{
				Player2.GetComponent<PlayerController> ().isFlipped = true;
				Player2.GetComponent<PlayerController> ().upInput = KeyCode.DownArrow;
				Player2.GetComponent<PlayerController> ().downInput = KeyCode.UpArrow;
				Player2.GetComponent<PlayerController> ().leftInput = KeyCode.RightArrow;
				Player2.GetComponent<PlayerController> ().rightInput = KeyCode.LeftArrow;
			}
			else if (Player2.GetComponent<PlayerController> ().isFlipped == true)
			{
				Player2.GetComponent<PlayerController> ().isFlipped = false;
				Player2.GetComponent<PlayerController> ().upInput = KeyCode.UpArrow;
				Player2.GetComponent<PlayerController> ().downInput = KeyCode.DownArrow;
				Player2.GetComponent<PlayerController> ().leftInput = KeyCode.LeftArrow;
				Player2.GetComponent<PlayerController> ().rightInput = KeyCode.RightArrow;
			}
		}
	}
}
