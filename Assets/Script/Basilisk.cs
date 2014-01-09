using UnityEngine;
using System.Collections;

public class Basilisk : MonoBehaviour {
	Transform turret;
	// Use this for initialization
	void Start () {
		turret = transform.Find("body").Find ("turret");
		if (!turret) {
			Debug.LogError ("turret child not found!");
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (turret != null) {
			turret.Rotate(0.0f, 20.0f * Time.deltaTime, 0.0f);
		}
	}
}
