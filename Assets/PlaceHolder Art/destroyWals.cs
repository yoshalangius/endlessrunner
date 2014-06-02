using UnityEngine;
using System.Collections;

public class destroyWals : MonoBehaviour {


	

	void onCollisionD2Enter(Collision2D other)
	{
		if(other.gameObject.tag == "Player")
		{
			other.gameObject.SetActive(false);
		}
	}

}
