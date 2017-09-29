using System.Collections;
using UnityEngine;

public class objectwall : MonoBehaviour 
{
	// Ded を参照する
	public Ded Ded;


	// Trigger との接触時に呼ばれる Callback
	private void OnTriggerEnter (Collider hit)
	{
		// 接触対象はPlayerタグかどうか
		if (hit.CompareTag ("Player"))
		{
			// Rigidbody を停止させる
			hit.GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeAll;

			// ゲームクリアを表示する
			Ded.ShowGameOverLabel();

		}
	}
}