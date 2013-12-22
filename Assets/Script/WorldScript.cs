using UnityEngine;
using System.Collections;

public class WorldScript : MonoBehaviour {
	public GameObject refCube;
	public GameObject[] cubes = new GameObject[100];

	Vector3 genCoordinate (Vector3 center, float dist) {
		float deg1 = Random.Range (0.0f, 360.0f);
		deg1 = deg1 * Mathf.Deg2Rad;
		float deg2 = Random.Range (0.0f, 360.0f);
		deg2 = deg2 * Mathf.Deg2Rad;

		float randDist = Random.Range (0.0f, dist);

		Vector3 coordinates;
		coordinates.x = randDist * Mathf.Sin (deg1) * Mathf.Cos (deg2);
		coordinates.y = randDist * Mathf.Sin (deg1) * Mathf.Sin (deg2);
		coordinates.z = randDist * Mathf.Cos (deg1);

		return coordinates;
	}

	// Use this for initialization
	void Start () {
		Vector3 temp;
		for (int ctr = 0; ctr < 100; ctr++) {
			temp = genCoordinate (Vector3.zero, 5.0f);
			cubes[ctr] = (GameObject)Instantiate (refCube, temp, Quaternion.identity);
		}
	}
}
