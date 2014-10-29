﻿using UnityEngine;
using System.Collections;

public class BasuraController : MonoBehaviour {
	private int numeroBasura;
	private int score_plastico;
	private int score_organico;
	private int score_papel;

	// Use this for initialization
	void Awake () 
	{
		numeroBasura = PlayerPrefs.GetInt ("numeroBasura");
		score_plastico = PlayerPrefs.GetInt ("score_plastico");
		score_organico = PlayerPrefs.GetInt ("score_organico");
		score_papel = PlayerPrefs.GetInt ("score_papel");
	}


	void Start () {
		Invoke ("DestruirBasura", 10f);
	}
	
	// Update is called once per frame
	void Update () {
		numeroBasura = PlayerPrefs.GetInt ("numeroBasura");
		score_organico = PlayerPrefs.GetInt ("score_organico");
		score_plastico = PlayerPrefs.GetInt ("score_plastico");
		score_papel = PlayerPrefs.GetInt ("score_papel");


		transform.Translate(new Vector2(0,  1* Time.deltaTime));
	}


	void DestruirBasura(){


		Destroy (gameObject);

	}

}
