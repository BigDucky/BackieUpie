using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {
	

	public Canvas buildingCanvas;
	public GameObject buildPanel;
	public Button factory;
	public Button recycleFacility;
	public Button house;
	public Button houseBlock;
	public Button garbageDisposal;

	public Text factoryCost;
	public Text factoryPollution;

	public Text recycleCost;
	public Text recylcePollution;

	public Text houseCost;
	public Text housePollution;

	public Text garbageCost;
	public Text garbagePollution;

	private int totalTextFields;

	/*public void Start(){
//		totalTextFields = GameLogic.totalBuildings;
		Debug.Log (totalTextFields);
	}


	void OnGUI(){
		for (int i = 0; i < totalTextFields; i++) {
			GUI.TextField (new Rect (10, 10, 50, 50), "Inserted Value",25);
		}
	}*/



}