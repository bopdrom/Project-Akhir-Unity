using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
	private BoxCollider2D boxCol;
	bool gerak = false;
	//batas = false;
	private Vector3 posisiAwal;
	private Vector3 posisiAkhir;

	Rigidbody2D rb;

	void Start()
	{
		PlayerPrefs.SetInt("Turn", 40);
		rb = GetComponent<Rigidbody2D>();
		boxCol = GetComponent<BoxCollider2D>();
		posisiAwal = transform.position;
		posisiAkhir = posisiAwal;
	}

	void Update()
	{
		if (!gerak)
		{
			if (Input.GetKeyDown(KeyCode.D) && Right.wallRight == false)
			{
				if (KenaKiri.kena)
				{
					gerak = false;
				}
				posisiAkhir = new Vector3(posisiAwal.x + 1f, transform.position.y, 0f);
				gerak = true;
				//boxCol.offset = new Vector2(0.30f, 0f);
				Turn();
			}
			else if (Input.GetKeyDown(KeyCode.A) && Left.wallLeft == false)
			{
				posisiAkhir = new Vector3(posisiAwal.x + -1f, transform.position.y, 0f);
				gerak = true;
				//boxCol.offset = new Vector2(-0.30f, 0f);
				Turn();
			}
			else if (Input.GetKeyDown(KeyCode.W) && Top.wallTop == false)
			{
				posisiAkhir = new Vector3(transform.position.x, posisiAwal.y + 1f, 0f);
				gerak = true;
				//boxCol.offset = new Vector2(0f, 0.30f);
				Turn();				
			}
			else if (Input.GetKeyDown(KeyCode.S) && Bottom.wallBottom == false)
			{
				posisiAkhir = new Vector3(transform.position.x, posisiAwal.y + -1f, 0f);
				gerak = true;
				//boxCol.offset = new Vector2(0f, -0.30f);
				Turn();
			}
		}
		if (gerak)
		{
			transform.position = Vector3.MoveTowards(transform.position, posisiAkhir, 5 * Time.deltaTime);

			// Cek jika objek sudah mencapai posisi akhir
			if (transform.position == posisiAkhir)
			{
				gerak = false;
				posisiAwal = transform.position;
			}
		}
		//print("left = " + Left.wallLeft);
		//print("right = " + Right.wallRight);
		//print("top = " + Top.wallTop);
		//print("bottom = " + Bottom.wallBottom);
	}

	void Turn()
	{
		int turn = PlayerPrefs.GetInt("Turn");
		turn = turn - 1;
		PlayerPrefs.SetInt("Turn", turn);

		print(turn);

		if (turn < 1)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}
