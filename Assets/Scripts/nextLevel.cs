using UnityEngine;
using System.Collections;

public class nextLevel : MonoBehaviour {
	public string nivel = "nivel_1";

	void OnTriggerEnter2D(Collider2D other) {
		if (other.transform.tag == "asteroide")
						Application.LoadLevel (nivel);
	}
}
