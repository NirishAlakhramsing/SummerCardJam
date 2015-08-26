using UnityEngine;
using System.Collections;

public class MouseSelecting : MonoBehaviour {

	Renderer rend;
	bool confirmed, selected;

	private string selection;


	// Use this for initialization
	void Start () {


		selection = "Nothing Selected yet";

		confirmed = false;
		selected = false;

		rend = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {

	}


	void OnMouseEnter(){

		if (!confirmed) {
			rend.material.SetColor ("_Color", Color.yellow);
		}
	}



	void OnMouseOver(){

		//confirms selecting by highlighting it yellow
		if (Input.GetMouseButtonDown (0) && !confirmed) {
			//ConfirmSelection();


			//highlight selected object with yellow
			rend.material.SetColor ("_Color", Color.green);
			
			// get name back what card it is.
			selection = gameObject.name;
			print (selection);
			
			//do something with that the previouse step
			
			//reset selection variable.
			selection = "Nothing selected";
		}
			
		if (Input.GetMouseButtonUp (0)&& !confirmed) {
				confirmed = true;
				print ("ik zet nu confirmed op true");
		}


		if (Input.GetMouseButtonUp (0) && selected) {
			rend.material.SetColor ("_Color", Color.white);
			selected = false;
			confirmed = false;
		}
	}
	

	void OnMouseExit(){

		if (confirmed) {
			//stays selected color yellow
			selected = true;
		} else {
			rend.material.SetColor ("_Color", Color.white);
		}
	}
}
