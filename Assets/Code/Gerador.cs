using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gerador : MonoBehaviour 
{
	public Button SalvarScore;
	public AudioSource Audio;
	public Text SeuScore;
	public GameObject Mae;
	public Text Texto;
	public GameObject Ator;
	public GameObject Jogador;
	private int contador = 1, i = 0;
	private bool continua = true;
	void FixedUpdate()
	{
		if(i == 100&& continua == true)
		{
			var inimigo = (GameObject)GameObject.Instantiate(Ator,Vector2.zero,Quaternion.identity);
			inimigo.transform.parent = Mae.transform;
			Audio.Play();
			contador++;
			Texto.text = contador.ToString();
		i = 0;
		}
		if (Input.GetKeyDown (KeyCode.G)) 
		{

			Collider2D[] hits = Physics2D.OverlapCircleAll(Jogador.transform.position,0.5f);
			bool valeu = true;
			foreach(Collider2D hit in hits)
			{
				if(hit.tag == "Enemy")
				{
					valeu = false;
				}
			}
			if(valeu == false)
			{
				contador = 0;
			}
			Global.score = contador;
			SeuScore.color = Color.white;
			SalvarScore.interactable = true;
			SalvarScore.image.color =  Color.white;
			Destroy (Mae);
			Texto.text = contador.ToString();

			continua = false;

		}
		i++;
	}
}
