using UnityEngine;
using System.Collections;

public class asteroide : MonoBehaviour {


	// Update is called once per frame
	void Update () {
	if (Input.GetKey ("t"))
						rigidbody2D.gravityScale = 1;
		if (Input.GetKey ("y"))
		
			rigidbody2D.AddForce(new Vector2(0,10));

	}
}
