using UnityEngine;
using System.Collections;

public class Gamecontroller : MonoBehaviour {

	//selectedball
	public GameObject selectedball;
	static public Material selectedballmat;
	static public int tokenscore = 0;
	public Transform ballspawnpoint;



	// Use this for initialization
	void Start () {

 
		ballspawnpoint = GameObject.FindWithTag("Ballspawnpoint").gameObject.transform;
		GameObject newball;
		newball = Instantiate(selectedball,ballspawnpoint.position,ballspawnpoint.rotation) as GameObject;
	//	selectedball.transform.position = ballspawnpoint.position;
		newball.renderer.material = selectedballmat;
 
	}
	
	// Update is called once per frame
	void Update () {
	
	if(Input.GetKeyDown(KeyCode.F))
		{
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
