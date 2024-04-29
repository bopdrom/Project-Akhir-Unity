using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KenaKiri : MonoBehaviour
{
    public static bool kena;
    /*private bool gerak = false;
    private Vector3 posisiAwal;
	private Vector3 posisiAkhir;

    void Start(){
        posisiAwal = transform.position;
		posisiAkhir = posisiAwal;
    }

    void Update(){
        if(gerak){
            transform.position = Vector3.MoveTowards(transform.position, posisiAkhir, 5 * Time.deltaTime);

            if (transform.position == posisiAkhir)
			{
				gerak = false;
				posisiAwal = transform.position;
			}
        }
    }*/

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col){
        if(col.tag == "Player"){
            Debug.Log("Kena");
            kena = true;
        }
    }

    void OnTriggerExit2D(Collider2D col){
        if(col.tag == "Player"){
            Debug.Log("Tidakkkk");
            kena = false;
        }
    }
}
