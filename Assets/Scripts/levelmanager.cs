using UnityEngine;
using System.Collections;

public class levelmanager : MonoBehaviour {

	//bool for game win level
	private bool levelreqmet = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

		if(levelreqmet){
			Application.LoadLevel("area2");
		}


	}
}
