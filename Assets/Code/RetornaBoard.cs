using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class RetornaBoard : MonoBehaviour 
{
	public string url;
	public Text Board;

	// Use this for initialization
	IEnumerator Start() 
	{
		WWW www = new WWW (url);
		yield return www;
		string[] board = www.text.Split(';');
		string texto = "";
		for(int i = 0; i< board.GetLength(0);i++)
		{
			texto += board[i] + Environment.NewLine;
		}
		Board.text = texto;
	}

}
