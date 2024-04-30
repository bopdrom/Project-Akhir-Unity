using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopCol : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D TopCol)
	{
		transform.parent.GetComponent<EnemyCol>().CollisionDetectedT(this);
	}
}
