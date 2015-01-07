using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public Transform other;
	void Update() {
		if (other) {
			Vector2 forward = transform.TransformDirection(Vector3.forward);
			Vector2 toOther = other.position - transform.position;
			if (Vector2.Dot(forward, toOther) < 0)
				print("The other transform is behind me!");
			
		}
	}
}