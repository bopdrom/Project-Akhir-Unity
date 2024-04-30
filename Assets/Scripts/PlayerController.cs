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
			if (Input.GetKeyDown(KeyCode.D) && BatasKanan.wallKanan == false)
			{
<<<<<<< Updated upstream
				if (KenaKiri.kena)
				{
					gerak = false;
				}
				posisiAkhir = new Vector3(posisiAwal.x + 1f, transform.position.y, 0f);
				gerak = true;
				//boxCol.offset = new Vector2(0.30f, 0f);
				Turn();
=======
				if(KenaKiri.kena){
					gerak = false;
				}else{
					posisiAkhir = new Vector3(posisiAwal.x + 1f, transform.position.y, 0f);
					gerak = true;
					//boxCol.offset = new Vector2(0.30f, 0f);
					//Turn();
				}
>>>>>>> Stashed changes
			}
			else if (Input.GetKeyDown(KeyCode.A) && BatasKiri.wallKiri == false)
			{
				if(KenaKanan.kena){
					gerak = false;
				}else{
					posisiAkhir = new Vector3(posisiAwal.x + -1f, transform.position.y, 0f);
					gerak = true;
					//boxCol.offset = new Vector2(0.30f, 0f);
					//Turn();
				}
			}
			else if (Input.GetKeyDown(KeyCode.W) && BatasAtas.wallAtas == false)
			{
				if(KenaBawah.kena){
					gerak = false;
				}else{
				posisiAkhir = new Vector3(transform.position.x, posisiAwal.y + 1f, 0f);
				gerak = true;
				//boxCol.offset = new Vector2(0f, 0.30f);
				//Turn();	
				}			
			}
			else if (Input.GetKeyDown(KeyCode.S) && BatasBawah.wallBawah == false)
			{
				if(KenaAtas.kena){
					gerak = false;
				}else{
				posisiAkhir = new Vector3(transform.position.x, posisiAwal.y + -1f, 0f);
				gerak = true;
				//boxCol.offset = new Vector2(0f, -0.30f);
				//Turn();
				}
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
<<<<<<< Updated upstream
		//print("left = " + Left.wallLeft);
		//print("right = " + Right.wallRight);
		//print("top = " + Top.wallTop);
		//print("bottom = " + Bottom.wallBottom);
	}

=======
		//Debug.Log(Batas.wall);
	}

	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Enemy")
		{
			Debug.Log("Kena");
		}
	}

	/*private void OnTriggerExit2D(Collider2D col)
	{
		if (col.transform.CompareTag("Batas"))
		{
			batas = false;
			Debug.Log(batas);
		}
	}*/

>>>>>>> Stashed changes
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
