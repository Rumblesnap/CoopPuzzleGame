using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortScript : MonoBehaviour {

	public GameObject destination = null;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player") {
			other.transform.position = destination.transform.position;
		}
	}
}
