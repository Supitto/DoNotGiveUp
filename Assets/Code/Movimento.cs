using UnityEngine;
using System.Collections;

public class Movimento : MonoBehaviour {
	public float forca;
	public AudioSource SomPulo;
	// Update is called once per frame
	void Update () 
	{
		//print (velocidade);
		if (Input.GetKeyDown(KeyCode.Space)) 
		{
			RaycastHit2D[] hits = Physics2D.RaycastAll(transform.position,-Vector2.up,0.2f);
			
			foreach(RaycastHit2D hit in hits)
			{
				if(hit.collider.tag != "Player")
				{
					this.rigidbody2D.AddForce(Vector2.up*forca*10);
					SomPulo.Play();
				}
			}
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			this.rigidbody2D.AddForce(Vector2.right*forca);
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			this.rigidbody2D.AddForce(Vector2.right*-forca);
		}
		if (Input.GetKeyDown(KeyCode.Escape)) 
		{
			System.Environment.Exit(0);
		}
	}

	
	
	
	
}