using UnityEngine;
using System.Collections;

public class initialrandomvelocity : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity = new Vector2 ((Random.value - .5f)*4, (Random.value - .5f)*4);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
