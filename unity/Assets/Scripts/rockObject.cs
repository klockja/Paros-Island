﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag == "Player") 
		{
			GameObject.Find ("Player").GetComponent<PlayerController> ().rockNum += 1;
			Destroy (gameObject);
			//Debug.Log ("playertouchrock");
		}
	}
}
