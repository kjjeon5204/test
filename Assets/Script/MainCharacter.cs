using UnityEngine;
using System.Collections;

public class MainCharacter : Character {
	/*
	public enum PlayerState {
		IDLE,
		MOVING
	}

	GameObject world;
	WorldScript curWorld;
	PotentialField currentField;
	MyMovement currentMovement;


	// Use this for initialization
	void Start () {
		currentField = new PotentialField (20.0f, 2.0f, true);
		currentMovement = new MyMovement (transform.position, transform.rotation);
		world = GameObject.Find ("world");
		curWorld = world.GetComponent<WorldScript>();
	}

	public void event_selector() {
		/*There are no conditional events for this script*/
	/*this
	}
	
	public void event_handler() {
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 eachMoveVect;
		transformData nextTransform;
		foreach (GameObject cube in curWorld.cubes) {
			if (cube != this.gameObject) {
				eachMoveVect = transform.position - cube.transform.position;
				eachMoveVect.Normalize ();
				eachMoveVect = currentField.calc_force (transform.position, cube.transform.position) *
					eachMoveVect;
				currentMovement.add_movment_vector(eachMoveVect);
			}
		}
		nextTransform = currentMovement.update_transformation(1.0f * Time.deltaTime);
		transform.Translate (nextTransform.vector);
	}
*/
}
