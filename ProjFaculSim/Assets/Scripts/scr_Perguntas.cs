using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Perguntas : MonoBehaviour {

	public scr_GameManager GameManager;
	public GameObject[] opcoes = new GameObject [4];
	public int clicado;

	// Use this for initialization
	void Start () {
		GameManager = GameObject.Find ("GameManager").GetComponent<scr_GameManager>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
