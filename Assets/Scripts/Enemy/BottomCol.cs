using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomCol : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D BottomCol)
	{
		transform.parent.GetComponent<EnemyCol>().CollisionDetectedB(this);
	}
}
