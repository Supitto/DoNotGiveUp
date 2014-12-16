using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CarregaCena : MonoBehaviour {
	public string Level;
	public void Troca()
	{
		Application.LoadLevel (Level);

	}

}
