﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float velocidad = 0.5f;

	public GameObject Basuraa1;
	public GameObject Basuraa2;
	public GameObject Basuraa3;

	private BasuraCreator Basura;

	private Vector3 PosicionBasura;
	private float BasuraEnX;
	private float BasuraEnY;
	private bool Mover=false;

	private int numeroBasura;
	
	void Awake () 
	{
		numeroBasura = PlayerPrefs.GetInt ("numeroBasura");
	}


	
	// Update is called once per frame
	void Update () {
		numeroBasura = PlayerPrefs.GetInt ("numeroBasura");
		// Movimiento
		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			transform.Translate(new Vector3(velocidad * Time.deltaTime,0,0));
		}
		
		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			transform.Translate(new Vector3(-velocidad * Time.deltaTime,0,0));
		}

		if (transform.position.x < -3.9f) 
		{
			transform.position = new Vector3(-3.9f, transform.position.y, transform.position.z);
			
		}
		
		if (transform.position.x > 4.0f) 
		{
			transform.position = new Vector3(4.0f, transform.position.y, transform.position.z);
			
		}


		if (Input.GetKeyDown (KeyCode.Space)){
			BasuraEnX = 0.45f;
			BasuraEnY = 1.1f;
			PosicionBasura = new Vector3 (BasuraEnX, BasuraEnY, 0);

			switch (numeroBasura) 
			{
			case 1:
				Instantiate(Basuraa1, transform.position + PosicionBasura, Quaternion.identity);
				break;
			case 2:
				Instantiate(Basuraa2, transform.position + PosicionBasura, Quaternion.identity);
				break;
			case 3:
				Instantiate(Basuraa3, transform.position + PosicionBasura, Quaternion.identity);
				break;
			default:
				break;
			}

		}

		else if (!Input.anyKey){
		}




	}
}
