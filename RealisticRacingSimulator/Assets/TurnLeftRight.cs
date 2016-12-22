using UnityEngine;
using System.Collections;
using Leap;
using Leap.Unity;

public class TurnLeftRight : MonoBehaviour {
 
	Controller controller = new Controller();
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Frame latest = controller.Frame(); //The latest frame
		Frame previous = controller.Frame(1); //The previous frame
		if (latest != previous) {
			if (transform.GetChild(0).gameObject.transform.position.y > transform.GetChild(1).gameObject.transform.position.y) {
			GameObject.Find("Map").transform.Rotate (Vector3.right * Time.deltaTime);	
			}
			else {
			GameObject.Find("Map").transform.Rotate (Vector3.left * Time.deltaTime);	

			}
		}
	}
}
