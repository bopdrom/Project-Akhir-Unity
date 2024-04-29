using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCol : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D LeftCol)
	{
		transform.parent.GetComponent<Enemy>().CollisionDetectedL(this);
	}
}
