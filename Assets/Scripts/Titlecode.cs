using UnityEngine;
using System.Collections;

public class Titlecode : MonoBehaviour {

	//collections of ball mats
	public Material[] ballmats;


//	// Use this for initialization
//	void Start () {
//	
//	}
//	
//	// Update is called once per frame
//	void Update () {
//	
//	}


public	void choseblue()
	{
		print ("blue");
		Gamecontroller.selectedballmat = ballmats[0];
		Application.LoadLevel("area1");
	}

public	void chosered()
	{
		print ("red");
		Gamecontroller.selectedballmat = ballmats[1];
		Application.LoadLevel("area1");
	}

public	void choseyellow()
	{
		print ("yellow");
		Gamecontroller.selectedballmat = ballmats[2];
		Application.LoadLevel("area1");
	}

}
