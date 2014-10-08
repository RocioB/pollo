using UnityEngine;
using System.Collections;

public class bombaScript : MonoBehaviour {

	void OnColissionEnter2D(Collision2D coll) {
		Debug.Log ("Se ha chocado contra la bomba");
		// if (coll.gameObject.tag == ""Enemy")
		// damage();
	}
}
