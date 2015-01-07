using UnityEngine;
using System.Collections;

public class FOVConeCollision : MonoBehaviour {
	int i = 0;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col){
		print ("Boom!" + i);
		i++;
	}
}
