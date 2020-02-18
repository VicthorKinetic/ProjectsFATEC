using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_GameManager : MonoBehaviour {
	
	public scr_Perguntas Perguntas;

	//gameobjects para modificar
	public GameObject texto;
	public GameObject op1;
	public GameObject op2;
	public GameObject op3;
	public GameObject op4;

	//perguntas acertadas
	public int acertos = 0;

	//simplificando atribuição de perguntas e respostas
	public string[] perguntas = new string[10];
	public string[] respostasop1 = new string[10];
	public string[] respostasop2 = new string[10];
	public string[] respostasop3 = new string[10];
	public string[] respostasop4 = new string[10];

	//ordem das respostas certas
	public int[] respostas = new int [] {1,3,0,2,2,1,3,0,1,2};


	// Use this for initialization
	void Start () {
		
		//encontrando cada objeto e atribuindo a sua variavel
		Perguntas = GameObject.Find ("QuestionManager").GetComponent<scr_Perguntas>();
		texto = GameObject.Find ("Pergunta");
		op1 = GameObject.Find ("textop1");
		op2 = GameObject.Find ("textop2");
		op3 = GameObject.Find ("textop3");
		op4 = GameObject.Find ("textop4");
	}
	
	// Update is called once per frame
	void Update () {
		
		//mudando o texto de cada objeto depois de cada pergunta
		texto.GetComponent<Text>().text = perguntas[acertos].ToString();
		op1.GetComponent<Text>().text = respostasop1[acertos].ToString();
		op2.GetComponent<Text>().text = respostasop2[acertos].ToString();
		op3.GetComponent<Text>().text = respostasop3[acertos].ToString();
		op4.GetComponent<Text>().text = respostasop4[acertos].ToString();
	}

	//verificação do botão clicado
	public void VerifEscolha (int numBut)
	{
		if (numBut == respostas [acertos]) {
			acertos++;
			Perguntas.opcoes [0].SetActive (true);
			Perguntas.opcoes [1].SetActive (true);
			Perguntas.opcoes [2].SetActive (true);
			Perguntas.opcoes [3].SetActive (true);
		} else {
			Perguntas.opcoes [numBut].SetActive (false);
		}
	}
}
