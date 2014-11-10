using UnityEngine;
using System.Collections;

public class Tokencode : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider tokenhit)
	{
		print ("hit");
		
		if(tokenhit.gameObject.name.StartsWith("Baller")&& Application.loadedLevelName == "area1")
		{
			print ("hit baller");
			Application.LoadLevel("area2");
		}
		
		if(tokenhit.gameObject.collider.tag == "Token")
		{
			Gamecontroller.tokenscore++;
		}
	}
}
