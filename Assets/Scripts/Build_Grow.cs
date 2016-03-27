using UnityEngine;
using System.Collections;

public class Build_Grow : MonoBehaviour {

	float grow = 0.01f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(transform.position.y < 30) {
			transform.position += new Vector3(0, grow, 0);
		}
	}
}
