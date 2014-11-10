using UnityEngine;
using System.Collections;

public class tokenspawn : MonoBehaviour {

	public GameObject[] tokenpointsgroup1;

	public GameObject newtoken;
	public int tokenspawnpointcount;


	// Use this for initialization
	void Start () {
		tokenpointsgroup1 = GameObject.FindGameObjectsWithTag("Tokenspawner");
		tokenspawnpointcount = tokenpointsgroup1.Length;
		createtokens();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void createtokens()
	{
		for(int i =0; i<tokenspawnpointcount; i++)
		{
			GameObject tokencopy;

			tokencopy = Instantiate(newtoken,tokenpointsgroup1[i].transform.position,tokenpointsgroup1[i].transform.rotation) as GameObject;
			tokencopy.transform.parent = tokenpointsgroup1[i].transform;
		}
	}
}
