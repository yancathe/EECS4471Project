using UnityEngine;
using System.Collections;
using Leap;
using Leap.Unity;
using System.Collections.Generic;

public class testHandGrab : MonoBehaviour {
	GameObject firstHand;
	LeapProvider provider;
	public GameObject[] steeringWheel;

	// Use this for initialization
	void Start () {
		 provider = FindObjectOfType<LeapProvider>() as LeapProvider;
	
	}
	
	// Update is called once per frame
	void Update () {
		float x = GameObject.Find("car_steering_wheel_new").transform.position.x;
		float y = GameObject.Find("car_steering_wheel_new").transform.position.y;
		float z = GameObject.Find("car_steering_wheel_new").transform.position.z;

		x = x + 1.64f;
		y = y + 3.63f;
		z = z - 0.41f;
		
	//	if (handController.unityHand == null)
        //    return;
		Vector3 handPosition = new Vector3(x, y, z);
		//print(x);
		//Controller controller = new Controller ();
		Frame frame = provider.CurrentFrame;
		List<Hand> hands = frame.Hands;
		//Hand firstHand = hands[0];
		
		//GameObject.Instantiate(firstHand, handPosition);
		//Vector handCenter = hand.palmPosition().
		//hand.PalmPosition = handPosition;
		//print(transform.position);
		/*steeringWheel =  GameObject.FindGameObjectsWithTag("Finish");
		 foreach (GameObject steeringWheel in steeringWheel) {
            Vector3 steeringPosition = new Vector3();
            steeringPosition = steeringWheel.transform.position;
        }


		Vector3 handGrabPosition = new Vector3();
		handGrabPosition = transform.position;
		
		transform.position = steeringPosition;*/
	
	}
}
