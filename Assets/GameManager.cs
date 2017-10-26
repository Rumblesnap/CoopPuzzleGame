using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject Player1 = null;
	public GameObject Player2 = null;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Player1.GetComponent<PlayerController> ().onGoal == true && Player2.GetComponent<PlayerController> ().onGoal == true) {
			print ("YOU WIN!");
		}
	}
}
