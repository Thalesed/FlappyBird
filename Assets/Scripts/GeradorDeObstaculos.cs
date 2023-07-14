﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour {

	[SerializeField] private float tempoParaGerar;
	private float cronometro;
	[SerializeField] private GameObject obstaculo;

	private void Awake() {
		this.cronometro = this.tempoParaGerar;
	}

	// Update is called once per frame
	private void Update () {
		this.cronometro -= Time.deltaTime;
		if (this.cronometro < 0) {
			GameObject.Instantiate(this.obstaculo, this.transform.position, Quaternion.identity);
			this.cronometro = this.tempoParaGerar;
		}
	}
}