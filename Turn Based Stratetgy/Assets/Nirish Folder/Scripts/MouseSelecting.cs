using UnityEngine;
using System.Collections;

public class MouseSelecting : MonoBehaviour {

	Renderer rend;
	Texture defaultText;

	bool confirmed;

	private string selection;


	// Use this for initialization
	void Start () {
		StartCoroutine(OnMouseOver());


		selection = "Nothing Selected yet";
		confirmed = false;

		defaultText = gameObject.GetComponent<Renderer> ().material.mainTexture;

		rend = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {

	}


	void OnMouseEnter(){
		if (!confirmed) {
			rend.material.SetColor ("_Color", Color.green);
		}
	}

	IEnumerator OnMouseOver(){

		yield return new WaitForSeconds(0.1f);
		//confirms selecting by highlighting it yellow
		if (Input.GetMouseButtonDown (0)&& !confirmed) {

			//highlight selected object with yellow
			rend.material.SetColor ("_Color", Color.yellow);

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


		yield return new WaitForSeconds(0.5f);

		if (Input.GetMouseButtonDown (0) && confirmed) {
			rend.material.SetColor ("_Color", Color.white);
		}

		if (Input.GetMouseButtonUp (0) && confirmed) {
			confirmed = false;
		}


	}


	void OnMouseExit(){

		if (confirmed) {
			//stays selected color yellow
		} else {
			rend.material.SetColor ("_Color", Color.white);
		}
	}


}
