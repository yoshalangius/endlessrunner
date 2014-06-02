using UnityEngine;
using System.Collections;

public class collecable : MonoBehaviour {

	private int count;
	public GUIText countText;
	
	void start()
	{
		count = 0;
		setCountText ();
		
	}
	
	void onTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "pickup") 
		{
			other.gameObject.SetActive(false);
			count = count + 1;
			setCountText();
		}
		
		
	}
	
	void setCountText()
	{
		countText.text = "count: " + count.ToString ();
		
	}
}
