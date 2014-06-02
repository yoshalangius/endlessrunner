﻿using UnityEngine;
using System.Collections;

public class PlayerFollow : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () 
	{
		offset = player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
		transform.position = player.transform.position + offset;
	}
}
