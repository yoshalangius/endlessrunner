using UnityEngine;
using System.Collections;

public class bgm : MonoBehaviour {
	private Vector3 pos;


	void Start () {
		pos = transform.position;
	}

	void Update () 
	{
		this.transform.position = pos;
		pos.x -= 5f * Time.deltaTime;
		
		
		
		
		
		if(pos.x <= -30){
			pos.x = 30; 
		}
		transform.position = pos;

		
	}
		
}
	
	
	

	
	