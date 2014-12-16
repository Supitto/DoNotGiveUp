using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GravarScore : MonoBehaviour 
{

	public CarregaCena trocador;
	public string url;
	public Text Nome;
	public Text Score;
	public void Run()
	{
		StartCoroutine(Gravar());
	}
	public IEnumerator Gravar() 
	{
		Debug.Log (url + "?Nome='" + Nome.text + "'&Score='" + Score.text + "'");
		WWW merda = new WWW(url+"?name='"+Nome.text+"'&score='"+Score.text+"'");
		yield return merda;
		trocador.Troca ();
	}
}
