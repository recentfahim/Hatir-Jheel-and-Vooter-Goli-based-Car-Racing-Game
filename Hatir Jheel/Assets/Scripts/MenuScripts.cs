using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuScripts : MonoBehaviour {

	public Button startmanu;
	public Button exitmanu;
	void Start()
	{
		startmanu = startmanu.GetComponent<Button> ();
		exitmanu = exitmanu.GetComponent<Button> ();

	}
	public void StartLevel()
	{
		Application.LoadLevel(4);
	}
	public void ExitGame()
	{
		Application.Quit();
	}
}
