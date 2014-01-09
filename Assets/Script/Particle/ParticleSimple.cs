using UnityEngine;
using System.Collections;

public class ParticleSimple : MonoBehaviour {	
	float velocity;
	float deceleration;

	// Use this for initialization
	void Start () {
		velocity = 8.0f;
		deceleration = 13.0f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0.0f, 0.0f, velocity * Time.deltaTime);
		velocity -= deceleration * Time.deltaTime;
		if (velocity < 1.0f) {
			Destroy (gameObject);
		}
	}
}
