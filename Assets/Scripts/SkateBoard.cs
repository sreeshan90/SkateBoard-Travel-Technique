using UnityEngine;
using System.Collections;

public class SkateBoard : MonoBehaviour {
	
	//The gameobjects being tracked
	public GameObject hmd;
	
	public GameObject leftleg;
	
	public GameObject rightleg;
	
    public string WiimoteName = "RightWiimote";	
	//speed
	public float speed = 1.0F;
	
	private float time = 0.0F;
  
	private bool moving = false;

	// Update is called once per frame
	void Update () {

		if(moving)
		{
			Debug.Log("moving");

			if(InputBroker.GetKeyDown(WiimoteName + ":A") && InputBroker.GetKeyDown(WiimoteName + ":B")) {
				//increase speed
				speed = speed+0.1f;
			
			}
			else{
				speed = 1.0F;
			}

			//move them forward
			CommonVariables.mappedPosition += leftleg.transform.forward * speed * Time.deltaTime;

		}

		//Starts the moving when we give push to the skate board

					if (leftleg.transform.localPosition.y + 0.1f < rightleg.transform.localPosition.y) {
						Debug.Log ("leg above ground");
						moving = true;
				
						//banking of head to change direction while moving
						float angle = Vector3.Angle (leftleg.transform.localPosition, hmd.transform.localPosition);
						float angleToBadded = (angle-90.0f); 
						float hmdEulerAngleX = hmd.transform.localEulerAngles.x;
						Debug.Log ("EULER ANGLE " + hmdEulerAngleX);
						CommonVariables.mappedRotation = Vector3.up * angleToBadded;
						time = 0.0F;
						Debug.Log ("EULER ANGLE " + hmdEulerAngleX);
				} else {
		
				moving = false;
				}

		time += Time.deltaTime;
		
	}


}
