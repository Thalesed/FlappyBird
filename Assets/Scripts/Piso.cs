using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piso : MonoBehaviour {

	[SerializeField] private float velocidade;
	private Vector3 posicaoInicial;
	private float tamanhoRealDaImagem;
	
	private void Awake(){
		this.posicaoInicial = this.transform.position;
		this.tamanhoRealDaImagem = this.GetComponent<SpriteRenderer>().size.x;
		float escala = this.transform.localScale.x;
		this.tamanhoRealDaImagem = tamanhoRealDaImagem * escala;
	}

	// Update is called once per frame
	void Update () {
		float deslocamento = Mathf.Repeat(this.velocidade * Time.time, this.tamanhoRealDaImagem);
		this.transform.position = this.posicaoInicial + Vector3.left * deslocamento;
	}
}
