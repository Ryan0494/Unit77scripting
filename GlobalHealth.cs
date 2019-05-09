using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalHealth : MonoBehaviour {

	public static int PlayerHealth = 10;
	public int InternalHealth;
	public GameObject HealthDisplay;

	void Update () {
		InternalHealth = PlayerHealth;
		HealthDisplay.GetComponent<Text> ().text = "Health: " + PlayerHealth;
		if (PlayerHealth == 0) {
				PlayerHealth = 10;
			SceneManager.LoadScene (2);
		}
	}
}
