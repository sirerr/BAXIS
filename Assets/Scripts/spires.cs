using UnityEngine;
using System.Collections;

public class spires : MonoBehaviour {

	public int ranxyz;
	public float ranrotatespeed =0;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		startran();

	}

	void startran()
	{
		ranxyz = Random.Range(0,3);

		switch (ranxyz)
		{
		case 0:
			transform.Rotate(ranrotatespeed,0,0);
			break;
		case 1:
			transform.Rotate(0,ranrotatespeed,0);
			break;
		case 2:
			transform.Rotate(0,0,ranrotatespeed);
			break;
		}
	}

IEnumerator  Waiter()
	{
		yield return new WaitForSeconds(.8f);
		startran();
	}

}
