using UnityEngine;
using System.Collections;

public class Widgets : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	


	}

	void zoomIn(GameObject gameObject){

		Vector3 scale = gameObject.transform.localScale;
		scale.y +=0.5f; 
		scale.x +=0.5f;
		scale.z +=0.5f; 
		gameObject.transform.localScale = scale;

	
	}

	void zoomOut(GameObject gameObject){
		
		Vector3 scale = gameObject.transform.localScale;
		scale.y -=0.5f; 
		scale.x -=0.5f;
		scale.z -=0.5f; 
		gameObject.transform.localScale = scale;
		
		
	}

	void changeColor(GameObject gameObject){

		if(gameObject.renderer.material.color == Color.blue){
			gameObject.renderer.material.color = Color.green;
		}
		else if(gameObject.renderer.material.color == Color.green){
			gameObject.renderer.material.color = Color.red;
		}
		else if(gameObject.renderer.material.color == Color.red){
			gameObject.renderer.material.color = Color.blue;
		}

	}
}
