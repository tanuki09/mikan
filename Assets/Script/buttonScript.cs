using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class buttonScript : MonoBehaviour {

	public void ButtonPush() {
		
		// 現在のシーン番号を取得
		int sceneIndex = SceneManager.GetActiveScene().buildIndex;

		// 現在のシーンを再読込する
		SceneManager.LoadScene (sceneIndex);
	}
}