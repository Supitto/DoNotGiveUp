using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CarregaScore : MonoBehaviour {

	public Text Score;
	// Use this for initialization
	void Start () 
	{
		Score.text = Global.score.ToString ();
	}
}
