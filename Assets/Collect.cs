using UnityEngine;
using System.Collections;

public class Collect : MonoBehaviour {


	

	
	void Start()
	{

	}




	
	void OnTriggerEnter2D(Collider2D other)
	{
		//Debug.Log("i fucking work");
		if (other.gameObject.tag == "Player") 
		{
			other.gameObject.SetActive(false);

		}
		
		
	}
	

	

}
