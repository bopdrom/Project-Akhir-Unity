using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Player")
		{
			SceneManager.LoadScene("Level1");
			Debug.Log("Kena");
		}
	}
}
