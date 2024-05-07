using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCol : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D RightCol)
	{
		transform.parent.GetComponent<EnemyCol>().CollisionDetectedR(this);
	}
}
