using UnityEngine;
using System.Collections;

public class Mazecontrol : MonoBehaviour {

	//maze being controlled
	public GameObject chosenmaze;
	//user input controls
	public float hor;
	public float ver;

	//chosen speed
	public float rotationspeed = 0;


	// Use this for initialization
	void Start () {
		chosenmaze = GameObject.FindWithTag("Maze");
	}
	
	// Update is called once per frame
	void Update () {
	
		hor = Input.GetAxis("Horizontal");
		ver = Input.GetAxis("Vertical");

		chosenmaze.gameObject.transform.Rotate(hor * rotationspeed,ver * rotationspeed,0);

	}
}
