using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Car;
using UnityStandardAssets.Utility;
public class End : MonoBehaviour {
	public int f=0;
	private bool hasWon = false;
	private float timer = 0;
	public float delay = 5f;
	private bool hasEnded = false;
	// Use this for initialization
	void Start () {

	}




	// Update is called once per frame
	void Update () {


		if(hasEnded)
			timer += Time.deltaTime;

		if (timer > delay) {
			if (hasWon)
				Application.LoadLevel (2);
			else
				Application.LoadLevel (3);
		}	

	}





	void OnTriggerEnter(Collider col)
	{

		Debug.Log (col.transform.parent.parent.gameObject.name);
		if (col.transform.parent.parent.gameObject.name == "Car") {

			hasEnded = true;
			col.transform.parent.parent.GetComponent<CarUserControl>().stop = true;
			if(f==1){
				hasWon = true;
			}else{
				hasWon = false;
			}




		}
		if (col.transform.parent.parent.gameObject.name == "CarWaypointBased") {
			f=1;
			col.transform.parent.parent.GetComponent<CarAIControl>().stop = true;



		}
		if (col.transform.parent.parent.gameObject.name == "CarWaypointBased02") {
			f=1;
			col.transform.parent.parent.GetComponent<CarAIControl>().stop = true;



		}
		if (col.transform.parent.parent.gameObject.name == "Car3") {
			f=1;
			col.transform.parent.parent.GetComponent<CarAIControl>().stop = true;



		}

	}




}
