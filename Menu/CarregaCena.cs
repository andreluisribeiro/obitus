using UnityEngine;
using System.Collections;

public class CarregaCena : MonoBehaviour {
	public string cena;

	void OnMouseClick() {
		if(cena != null && cena != "")
			Application.LoadLevel (cena);
	}
}
