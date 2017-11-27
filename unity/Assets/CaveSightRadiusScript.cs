﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveSightRadiusScript : MonoBehaviour {

	private GameObject Player;

	// Use this for initialization
	void Start () 
	{
		Player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate ((Player.transform.position - transform.position) * Time.deltaTime * 3);
	}
}
