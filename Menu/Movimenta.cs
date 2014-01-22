using UnityEngine;
using System.Collections;

public class Movimenta : MonoBehaviour {
	public float velocidade;

	public float raio;
	public float angulo;

	void Start () {
		raio = Vector3.Distance (new Vector3 (0, 0, 0), this.transform.position);	
		angulo = Mathf.Atan2 (0-transform.position.y, 0-transform.position.x);
	}
	

	void Update () {
		angulo += velocidade * Time.deltaTime * (Mathf.PI/180);
		Vector3 posicao = new Vector3();
		posicao.x = raio * Mathf.Cos (angulo);
		posicao.y = raio * Mathf.Sin (angulo);

		this.transform.position = posicao;
	}
}
