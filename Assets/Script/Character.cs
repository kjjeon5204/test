using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {
	/*this
	public class PotentialField {
		struct PotentialData {
			public float potentialForce;
			public float degradeRate;
			public bool isPositive;
		}

		PotentialData myPotentialData;


		public PotentialField(float inForce, float inDegrade, bool inPositive) {
			myPotentialData.potentialForce = inForce;
			myPotentialData.degradeRate = inDegrade;
			myPotentialData.isPositive = inPositive;
		}

		/*
		Requires: Valid potentialFields for pos1 and pos2
		Effect: pos1 represents the location of current charge and pos2
				represents the location of the target object. Calculate
				how much force is exerted on the object at pos2 by the field
				located at pos1 and return the force. Returns 0 if force is 
				negative.
		Modfies: Nothing
		*/
		/* this
		public float calc_force (Vector3 pos1, Vector3 pos2) {
			float dist = Vector3.Distance(pos1, pos2);
			float finalForce = myPotentialData.potentialForce - 
				myPotentialData.degradeRate * dist;
			if (finalForce > 0)
				return finalForce;
			else return 0;
		}

		public bool isPositive() {
			if (myPotentialData.isPositive == true) return true;
			else return false;
		}


	}

	public struct transformData {
		public Quaternion quaternion;
		public Vector3 vector;
	}


	public class MyMovement {
		private Vector3 currentPosition;
		private Quaternion currentQuaternion;
		private Quaternion nextRotationQuat;
		private Vector3 nextMovementVect;


		public MyMovement(Vector3 pos, Quaternion qua) {
			currentPosition = pos;
			currentQuaternion = qua;
		}

		public void add_movment_vector (Vector3 vectAdder) {
			nextMovementVect += vectAdder;
		}

		public void add_movement_x (float x) {
			nextMovementVect.x += x;
		}

		public void add_movment_y (float y) {
			nextMovementVect.y +=y;
		}

		public void add_movement_z (float z) {
			nextMovementVect.z += z;
		}

		public void add_rotation (Quaternion input) {
			nextRotationQuat.eulerAngles += input.eulerAngles;
		}

		public void add_rotation_x (float x) {
			nextRotationQuat.eulerAngles += new Vector3 (x, 0, 0);
		}

		public void add_rotation_y (float y) {
			nextRotationQuat.eulerAngles += new Vector3 (0, y, 0);
		}

		public void add_rotation_z (float z) {
			nextRotationQuat.eulerAngles += new Vector3 (0, 0, z);
		}

		public transformData update_transformation(float speed) {
			nextMovementVect.Normalize();
			nextMovementVect *= speed;
			currentPosition += nextMovementVect;
			currentQuaternion.eulerAngles += nextRotationQuat.eulerAngles;
			transformData temp;
			temp.quaternion = nextRotationQuat;
			temp.vector = nextMovementVect;
			nextRotationQuat = Quaternion.identity;
			nextMovementVect = Vector3.zero;
			return temp;
		}

		public Quaternion return_rotation() {
			return currentQuaternion;
		}

		public Vector3 return_pos() {
			return currentPosition;
		}
	}

	struct DamageVal {

	}

	public virtual void on_death();

	public virtual float on_hit();

	


	/*
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	*/
}
