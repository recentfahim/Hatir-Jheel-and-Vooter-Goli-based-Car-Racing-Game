using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MapSelect : MonoBehaviour {



		public Button HatirJheel;
	public Button VooterGoli;
		public Button BackToMainMenu;
		void Start()
		{
			HatirJheel = HatirJheel.GetComponent<Button> ();
		BackToMainMenu = BackToMainMenu.GetComponent<Button> ();
		VooterGoli = VooterGoli.GetComponent<Button> ();

		}
		public void HatirJheelLevel()
		{
			Application.LoadLevel(1);
		}
		public void VooterGoliLevel()
		{
			Application.LoadLevel(2);
		}
		public void BackToMainMenuLevel()
		{
		Application.LoadLevel (0);
		}

}
