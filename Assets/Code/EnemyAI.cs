using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour 
{
	public GameObject Player;
	public float forca;
	private float x, y;
	private Vector2 vetor;
	void Update()
	{
		if (this.transform.position.x < Player.transform.position.x) 
		{
			x = forca;
		}
		else
		{
			x = -forca;
		}
		if (this.transform.position.y < Player.transform.position.y) 
		{
			y = forca;
		}
		else
		{
			y = -forca;
		}
		vetor = new Vector2 (x, y);
		this.rigidbody2D.AddForce (vetor);
	}
}
