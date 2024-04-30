using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCol : MonoBehaviour
{
	// Start is called before the first frame update
	public void CollisionDetectedL(LeftCol childScript)
	{
		transform.Translate(1f, 0, 0);
		Debug.Log("Kena Enemy Left");
	}
	public void CollisionDetectedR(RightCol childScript)
	{
		transform.Translate(-1f, 0, 0);
		Debug.Log("Kena Enemy Right");
	}
	public void CollisionDetectedT(TopCol childScript)
	{
		transform.Translate(0, -1f, 0);
		Debug.Log("Kena Enemy Top");
	}
	public void CollisionDetectedB(BottomCol childScript)
	{
		transform.Translate(0, 1f, 0);
		Debug.Log("Kena Enemy Bottom");
	}
}
