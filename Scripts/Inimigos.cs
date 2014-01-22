using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animation))]

public class Inimigos : MonoBehaviour {
	public float distanciaParaPerseguir;
	public float distanciaParaAtacar;
	public float velocidade;
	
	void Atacar() {
		float distanciaParaJogador = Vector3.Distance (Jogador.posicao, transform.position);
		if (distanciaParaJogador > distanciaParaAtacar) {
				animation.Play ("Attack");
				SendMessage ("Atacar");
		}
	}

	void Movimentar() {
		float distanciaParaJogador = Vector3.Distance (Jogador.posicao, transform.position);

		if (distanciaParaJogador < distanciaParaPerseguir &&
			distanciaParaJogador > distanciaParaAtacar) {

			if (!animation.IsPlaying ("Move"))
					animation.Play ("Move");

			transform.position = Vector3.Slerp (transform.position, Jogador.posicao,
                                   velocidade / 42 * Time.deltaTime);
		} 
		else if (distanciaParaJogador > distanciaParaPerseguir &&
		         !animation.IsPlaying ("Move")) {
			animation.Play ("Move");
		}
	}


	/**
	 * Funçoes Unity
	 **/

	void Start() {
		animation.Play ("Idle");
	}

	// Update is called once per frame
	void Update () {
		Movimentar ();
		Atacar ();
	}
}
 