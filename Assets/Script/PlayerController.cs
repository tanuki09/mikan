using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
	private void FixedUpdate ()
	{
		float x = Input.GetAxis("Horizontal");	// Horizontal は水平方向
		float z = Input.GetAxis("Vertical");	// Vertical は垂直方向	

		// Player が持つ Rigidbody コンポーネントを取得
		Rigidbody rigidbody = GetComponent<Rigidbody>();

		// rigidbody のx軸（横）とz軸（奥）に力を加える
		rigidbody.AddForce(x * 5, 0, z * 5);

	}
}
