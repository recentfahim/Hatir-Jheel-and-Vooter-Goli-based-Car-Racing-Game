using UnityEngine;
using System.Collections;

public class sceneChange : MonoBehaviour {

	public static void changeToscene(string SceneToChaneTo)
	{
		Application.LoadLevel (SceneToChaneTo);
	}
}
