using UnityEngine;
using System.Collections;

public class movePlayermock : MonoBehaviour {

	private int count;
	public GUIText countText;

	void Update ()
	{
		bool down = Input.GetKeyDown(KeyCode.Space);
		bool held = Input.GetKey(KeyCode.Space);
		bool up = Input.GetKeyUp(KeyCode.Space);

		if (down) {
			//Debug.Log ("works");

			rigidbody2D.AddForce (Vector3.up * 300);

		}

		else if(up)
		{
			rigidbody2D.AddForce (Vector3.up * -300);
		}


	}
	// y = 21.48421

	void Start()
	{
		count = 0;
		setCountText();
	}




	void OnTriggerEnter2D(Collider2D other)
	{
		//Debug.Log("i fucking work");
		if (other.gameObject.tag == "PickUp") 
		{
			other.gameObject.SetActive(false);
			count = count + 1;
			setCountText();
			//Debug.Log("i fucking work");
		}
		
		
	}
	
	void setCountText()
	{
		countText.text = "count: " + count.ToString ();
		//Debug.Log("i fucking work");
	}

}
