using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneStart : MonoBehaviour {

	public GameObject Cam;
	public GameObject hiden;
	public GameObject player;

	// Use this for initialization
	void Start () {
		Cam.SetActive (true);
		hiden.SetActive (false);
		player.SetActive (false);
		StartCoroutine (wait ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator wait () {
		yield return new WaitForSeconds (25);
		hiden.SetActive (true);
		player.SetActive (true);
	}
}
