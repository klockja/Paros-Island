﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour {

	private string nextScene;
	private string currentScene;
	private bool backward;

	void OnDrawGizmos()
	{
		Gizmos.color = Color.green;
		Gizmos.DrawCube (transform.position, new Vector2 (0.75f, 0.75f));
	}

	void Start () 
	{
		currentScene = SceneManager.GetActiveScene ().name;


	}

	void Update () 
	{
		//Debug.Log (nextScene);
		//backward = GameObject.Find ("GameManager").GetComponent<GameManagement> ().goingBackwards;
		//DetermineDirection ();
		DetermineNextScene ();
	}

	void DetermineDirection()
	{
		//if (backward == false && currentScene != "Cave")
		//{
			//transform.localPosition = new Vector3 (0, 10, 0);
		//} else if (backward == true || currentScene == "Cave") 
		//{
			//transform.localPosition = new Vector3 (0, -12, 0);
		//}
	}

	protected string DetermineNextScene()
	{
		//Debug.Log (currentScene);
		if (currentScene == "Beach") {
			nextScene = "Forest";
			return nextScene;
		} else if (currentScene == "Forest") {
			nextScene = "Cave";
			return nextScene;
		}  else if (currentScene == "Cave") {
			nextScene = "Forest2";
			return nextScene;
		}  else if (currentScene == "Forest2") {
			nextScene = "Beach2";
			return nextScene;
		} else if ((currentScene == "Beach2")) {
			GameObject.Find ("Canvas").GetComponent<ui> ().Panel5.SetActive (true);
			nextScene = null;
			return nextScene;
		} else 
		{
			//Debug.Log ("Error In PortalScript");
			return nextScene;
		}
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "Player") 
		{
			GameObject.Find ("GameManager").GetComponent<GameManagement> ().nextScene = true;
			SceneManager.LoadScene(nextScene);
		}
	} 


}
