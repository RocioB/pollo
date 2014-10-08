using UnityEngine;
using System.Collections;

public class gameScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			reiniciar ();
		}
	
	}
	public void salir () {
		Application.Quit ();
		}
	public void reiniciar () {
		Application.LoadLevel ("Menu");
		}
	public void Iniciar () {
		Application.LoadLevel ("nivel_1");
	}
}
