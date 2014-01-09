using UnityEngine;
using System.Collections;

public class MyParticleEmitter : MonoBehaviour {

	public GameObject particle;
	protected GameObject[] createdParticle = new GameObject[20];

	float startTime;
	float endTime;
	int ctr;

	// Use this for initialization
	void Start () {
		ctr = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (ctr < 20) {
			Quaternion rot = Quaternion.Euler(Random.Range (0.0f, 360.0f), 90.0f, 270.0f);
			createdParticle[ctr] = (GameObject)Instantiate (particle, transform.position, rot);
			Debug.Log (ctr);
		}
		ctr++;
		Destroy (gameObject, 5.0f);
	}
}
