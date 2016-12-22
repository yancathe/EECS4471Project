using UnityEngine;
using System.Collections;
using Leap;
using Leap.Unity;

using Pose = Thalmic.Myo.Pose;
using VibrationType = Thalmic.Myo.VibrationType;

public class handOnWheel : MonoBehaviour {

	public GameObject myo = null;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		ThalmicMyo thalmicMyo = myo.GetComponent<ThalmicMyo> ();
		
		//Find out the origin point of the steering wheel coord in WCS
		float x = GameObject.Find("car_steering_wheel_new").transform.position.x;
		float y = GameObject.Find("car_steering_wheel_new").transform.position.y;
		float z = GameObject.Find("car_steering_wheel_new").transform.position.z;

		// Figure out the offset for the value by trial and error
		x = x + 1.64f;
		y = y + 3.63f;
		z = z - 0.41f;	
		
		// Set a nrmal hand position and then a left and a right one 
		Vector3 handPosition = new Vector3(x, y, z);
		Vector3 leftHandPosition = new Vector3(x+0.4f, y-0.07f, z+0.1f);
		Vector3 rightHandPosition = new Vector3(x-0.2f, y-0.05f, z+0.08f);

		// Checks if arm in scene is certain distance from steering wheel
	if ((Vector3.Distance(transform.GetChild(0).gameObject.transform.position, handPosition) < 30 
	|| (Vector3.Distance(transform.GetChild(1).gameObject.transform.position, handPosition)) < 30 ))
	{		
		//If distance achieved, checks for fist
		 if (thalmicMyo.pose == Pose.Fist) {
		GameObject go = (GameObject)Instantiate(Resources.Load("RiggedPepperFullHands"));
		
		//spawn left hand at hard-coded area
		GameObject leftHand = go.transform.GetChild (1).gameObject;
		leftHand.transform.position = leftHandPosition;
		leftHand.transform.Rotate(new Vector3(0,90,0));
		
		//spawn right hand at hard-coded area
		GameObject rightHand = go.transform.GetChild (0).gameObject;
		rightHand.transform.position = rightHandPosition;
		rightHand.transform.Rotate(new Vector3(0,90,0));
		}
    }
	}
}
