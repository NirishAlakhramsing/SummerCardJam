using UnityEngine;
using System.Collections;

public class CardCreation : DeckMenuEvent {

	//public string[] selectableTitle;
	
	//private string classTitle;

	private int health, atp, currentPos;
	private string currentName;
	public string[] title;

	public Material[] getTex;
	//public string title;
	private Quaternion rot;

	private Renderer rend;
	//public DeckMenuEvent nameGetter;

	//default stats for the an card.
	public CardCreation() {
		currentName = "default";
		health = 10;
		atp = 2;

		rot.eulerAngles = new Vector3 (90, 180, 0);
	}

	void Awake(){
		rend = GetComponent<Renderer>();
	}
	
	// Use this for initialization
	void Start () {
		CreateCard ();
	}

	public void CreateCard(){

	//1. Set a random texture for this model.
		int rdTex = Random.Range (0, 4);
		rend.material = getTex [rdTex];

	//2. Give it a random title name
		int rdName = Random.Range (0, 4);
		currentName = title[rdName];

	//3. Set additional Healthpoints.


	//4. et random attack power range.

		atp = Random.Range(2, 7);

	//5. Save card to selectableCards Array.


	//6. after being instanced, card faces player view.
		transform.rotation = rot;

	}
	
}
