using UnityEngine;
using System.Collections;

public class testMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	if (Input.GetKey("w")){
		 GameObject.Find("Map").transform.position =  GameObject.Find("Map").transform.position + GameObject.Find("Map").transform.right * 1f;
    }

    if (Input.GetKey("s")){
   transform.position = transform.position + transform.forward * 1f;	
    }
 
     if (Input.GetKey("d")) {

		transform.Rotate (new Vector3 (0f, 1f, 0f));


	}

	if (Input.GetKey ("a")) {
		transform.Rotate (new Vector3  (0f,-1f,0f )); 
	}

	if (Input.GetKey ("q")) {
	}
	}
	
	//void onCollisionEnter(Collision collision) {
		//if (collision.GameObject.Find("general_barricades_carstop_double") == true) {
			//GetComponent<Rigidbody>().velocity = Vector3.zero;
		//}
	
}
