using UnityEngine;
using System.Collections;

public class DeckMenuEvent : MonoBehaviour {


	private Vector3[] cardPosition;

	public bool pickCards;

	private const int selectAmount = 5;
	private int created= 0;

	public GameObject card;

	void Awake(){
		cardPosition = new Vector3[5];
		pickCards = false;
	}

	
	// Use this for initialization
	void Start () {

		cardPosition[0] = GameObject.Find ("FirstCardPosition").transform.position;
		cardPosition[1] = GameObject.Find ("SecondCardPosition").transform.position;
		cardPosition[2] = GameObject.Find ("ThirdCardPosition").transform.position;
		cardPosition[3] = GameObject.Find ("FourthCardPosition").transform.position;
		cardPosition[4] = GameObject.Find ("FifthCardPosition").transform.position;

	}
	
	// Update is called once per frame
	void Update () {

		if (pickCards && !(created == 5)) {
			CreateCard(selectAmount);
			created ++;
		}
	}


	public void CreateCard(int totalAmount){

		Instantiate (card, cardPosition[created], Quaternion.identity);

	}


}
