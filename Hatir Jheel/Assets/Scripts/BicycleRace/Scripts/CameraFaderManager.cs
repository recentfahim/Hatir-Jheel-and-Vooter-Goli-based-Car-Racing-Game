using UnityEngine;
using System.Collections;
using System;


public class CameraFaderManager : MonoBehaviour 
{
	bool clicked;
	public void FadeCamAndShowCycle()
	{
		CameraFade.StartAlphaFade (Color.white, true, 10, 0);
		//Active cycle and deactive car here;
	}
	public void FadeCamAndShowCar()
	{
		CameraFade.StartAlphaFade (Color.white, true, 10, 0);
		//Active car and deactive cycle here;
	}
	public void show(GameObject g)
	{
		clicked = !clicked;

		if (clicked) {
			g.SetActive (true);
		} 
		else 
		{
			Vector2 temp = g.GetComponent<RectTransform> ().anchoredPosition;
			temp.x = 650;
			g.GetComponent<RectTransform> ().anchoredPosition = temp;
			g.SetActive (false);
		}
	}
}
