using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Desfocador : MonoBehaviour {
	public Button botao;
	// Use this for initialization
	void Start () {
	}
	public void desfoca()
	{
		botao.interactable = false;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
