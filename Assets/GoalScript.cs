using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour {

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
			Player1.GetComponent<PlayerController> ().onGoal = true;
		}
		if (other.gameObject.name == "Player 2") {
			Player2.GetComponent<PlayerController> ().onGoal = true;
		}
	}

	void OnTriggerExit (Collider other)
	{
		if (other.gameObject.name == "Player 1") {
			Player1.GetComponent<PlayerController> ().onGoal = false;
		}
		if (other.gameObject.name == "Player 2") {
			Player2.GetComponent<PlayerController> ().onGoal = false;
		}
	}

}
