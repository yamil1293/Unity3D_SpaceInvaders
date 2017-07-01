﻿using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	public float rightEdgePadding;
	public float leftEdgePadding;
	public float dropDistance = 1.0f;

	private int direction = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 newPosition = transform.position;
		newPosition.x += ScoreKeeper.speed * direction * Time.deltaTime; 
		transform.position = newPosition;

		if (Camera.main.WorldToScreenPoint(transform.position).x > Screen.width - rightEdgePadding)
		{
			direction = -1;
			newPosition = transform.position;
			//float cameraObjectZDifference = transform.position.x - Camera.main.transform.position.z;
			newPosition.x = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,0,-10)).x;
			newPosition.y -= dropDistance; 
			transform.position = newPosition;
		}
		else if (Camera.main.WorldToScreenPoint(transform.position).x < 0 + leftEdgePadding)
		{
			direction = 1;
			newPosition = transform.position;
			newPosition.x = Camera.main.ScreenToWorldPoint(new Vector3(0,0,-10)).x;
			newPosition.y -= dropDistance; 
			transform.position = newPosition;
		}
	}
}
