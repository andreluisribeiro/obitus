using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour {
	public static Vector3 posicao;

	// Update is called once per frame
	void Update () {
		posicao = this.transform.position;
	}
}
